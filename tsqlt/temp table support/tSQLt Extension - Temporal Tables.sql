CREATE PROCEDURE tSQLt.Private_CreateFakeOfTablePreserveNullability
@SchemaName             NVARCHAR(MAX),
@TableName              NVARCHAR(MAX),
@OrigTableFullName      NVARCHAR(MAX),
@Identity               BIT,
@ComputedColumns        BIT,
@Defaults               BIT,
@PreserveNullability    BIT
AS
BEGIN
    DECLARE @Cmd NVARCHAR(MAX);
    DECLARE @Cols NVARCHAR(MAX);
   
    SELECT @Cols = (SELECT ',' + QUOTENAME(name) + cc.ColumnDefinition + dc.DefaultDefinition + id.IdentityDefinition +
        CASE WHEN cc.IsComputedColumn = 1 OR id.IsIdentityColumn = 1 THEN ''
            WHEN @PreserveNullability = 1 AND c.is_nullable = 0 THEN ' NOT NULL'
            ELSE ' NULL'
        END
        FROM sys.columns c CROSS APPLY tSQLt.Private_GetDataTypeOrComputedColumnDefinition(c.user_type_id, c.max_length, c.precision, c.scale, c.collation_name, c.object_id, c.column_id, @ComputedColumns) cc
            CROSS APPLY tSQLt.Private_GetDefaultConstraintDefinition(c.object_id, c.column_id, @Defaults) AS dc
            CROSS APPLY tSQLt.Private_GetIdentityDefinition(c.object_id, c.column_id, @Identity) AS id
        WHERE object_id = OBJECT_ID(@OrigTableFullName)
        ORDER BY column_id
        FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)');
    
    SELECT @Cmd = 'CREATE TABLE ' + @SchemaName + '.' + @TableName + '(' + STUFF(@Cols,1,1,'') + ')';
   
    EXEC sp_executesql @Cmd;
END;
GO

CREATE PROCEDURE tSQLt.Private_CreatePrimayKey
@SchemaName             NVARCHAR(MAX),
@TableName              NVARCHAR(MAX),
@OriginalTableObjectID  BIGINT
AS
BEGIN
    DECLARE @Cmd    NVARCHAR(MAX),
            @PKCols NVARCHAR(MAX);

    WITH IndexCTE
    AS
    (SELECT c.name, ic.key_ordinal
    FROM sys.indexes i INNER JOIN sys.index_columns ic ON i.object_id = ic.object_id
        INNER JOIN sys.columns c ON ic.object_id = c.object_id AND ic.column_id = c.column_id
    WHERE ic.object_id = @OriginalTableObjectID AND i.is_primary_key = 1)
    SELECT @PKCols = CAST(LTRIM(RTRIM(STUFF((SELECT ', [' + name + ']'
                                                FROM IndexCTE
                                                ORDER BY IndexCTE.key_ordinal
                                                FOR XML PATH ('')),1,1,''))) AS VARCHAR(MAX));

    SELECT @Cmd = 'ALTER TABLE ' + @SchemaName + '.' + @TableName + ' ADD CONSTRAINT [' + CAST(NEWID() AS NVARCHAR(MAX)) + '] PRIMARY KEY (' + @PKCols + ');';

    EXEC sp_executesql @Cmd;
END;
GO

CREATE PROCEDURE tSQLt.Private_FakeTableAddTemporal
@SchemaName             NVARCHAR(MAX),
@TableName              NVARCHAR(MAX),
@OriginalTableObjectID  BIGINT,
@HistoryTableObjectID   BIGINT
AS
BEGIN
    DECLARE @Cmd                    NVARCHAR(MAX),
            @StartColumn            NVARCHAR(128),
            @EndColumn              NVARCHAR(128),
            @HistorySchema          NVARCHAR(MAX),
            @HistoryTable           NVARCHAR(MAX),
            @NewNameOfHistoryTable  NVARCHAR(MAX);


    SELECT @HistorySchema = QUOTENAME(SCHEMA_NAME(schema_id)), @HistoryTable = QUOTENAME(name)
    FROM sys.tables
    WHERE object_id = @HistoryTableObjectID;

    EXEC tSQLt.Private_RenameObjectToUniqueName @HistorySchema, @HistoryTable, @NewNameOfHistoryTable OUTPUT;

    SELECT @StartColumn = name
    FROM sys.columns
    WHERE object_id = @OriginalTableObjectID AND generated_always_type = 1;

    SELECT @EndColumn = name
    FROM sys.columns
    WHERE object_id = @OriginalTableObjectID AND generated_always_type = 2;

    SET @Cmd = 'ALTER TABLE ' + @SchemaName + '.' + @TableName + ' ADD PERIOD FOR SYSTEM_TIME (' + QUOTENAME(@StartColumn) + ', ' + QUOTENAME(@EndColumn) + ');';

    EXEC sp_executesql @Cmd;

    SET @Cmd = 'ALTER TABLE ' + @SchemaName + '.' + @TableName + ' SET(SYSTEM_VERSIONING = ON (HISTORY_TABLE = ' + @HistorySchema + '.' + @HistoryTable + ', DATA_CONSISTENCY_CHECK = ON));';
SELECT @SchemaName, @TableName, @OriginalTableObjectID, @HistorySchema HistorySchema, @HistoryTable HistoryTable, @HistoryTableObjectID HostoryObjectID, @StartColumn, @EndColumn, @Cmd;

    EXEC sp_executesql @Cmd;

    EXEC tSQLt.Private_MarkFakeTable @HistorySchema, @HistoryTable, @NewNameOfHistoryTable;
END;
GO

CREATE PROCEDURE tSQLt.FakeTableTemporal
    @TableName              NVARCHAR(MAX),
    @SchemaName             NVARCHAR(MAX) = NULL,
    @Identity               BIT = NULL,
    @ComputedColumns        BIT = NULL,
    @Defaults               BIT = NULL,
    @PreserveNullability    BIT = NULL,
    @PreservePrimaryKey     BIT = NULL,
    @PreserveTemporal       BIT = NULL
AS
BEGIN
    DECLARE @OrigSchemaName          NVARCHAR(MAX);
    DECLARE @OrigTableName           NVARCHAR(MAX);
    DECLARE @NewNameOfOriginalTable  NVARCHAR(4000);
    DECLARE @OrigTableFullName       NVARCHAR(MAX);
    DECLARE @OriginalTableObjectID   BIGINT; --Used to hold the object_id for a temporal table
    DECLARE @HistoryTableObjectID    BIGINT; --Used to hold the object_id of a history table
   
    SET @OrigTableFullName = NULL;

    SELECT @OrigSchemaName = @SchemaName, @OrigTableName = @TableName;
   
    IF(@OrigTableName NOT IN (PARSENAME(@OrigTableName,1),QUOTENAME(PARSENAME(@OrigTableName,1))) AND @OrigSchemaName IS NOT NULL)
    BEGIN
        RAISERROR('When @TableName is a multi-part identifier, @SchemaName must be NULL!',16,10);
    END;

    SELECT @SchemaName = CleanSchemaName, @TableName = CleanTableName
    FROM tSQLt.Private_ResolveFakeTableNamesForBackwardCompatibility(@TableName, @SchemaName);

    IF @PreservePrimaryKey = 1 AND NOT EXISTS (SELECT 1 FROM sys.indexes WHERE object_id = OBJECT_ID(PARSENAME(@SchemaName,1) + '.' + PARSENAME(@TableName,1)) AND is_primary_key = 1)
    BEGIN
        --Table has to already have a primary key
        SET @PreservePrimaryKey = 0;
    END;

    IF @PreserveTemporal = 1 AND NOT EXISTS (SELECT 1 FROM sys.tables WHERE schema_id = SCHEMA_ID(PARSENAME(@SchemaName,1)) AND name = PARSENAME(@TableName,1) AND history_table_id IS NOT NULL)
    BEGIN
        --Table has to already be a temporal table
        SET @PreserveTemporal = 0;
    END;

    IF @PreserveTemporal = 1
    BEGIN
        --Primary key is required for temporal tables
        SET @PreservePrimaryKey = 1;
    END;

    IF @PreservePrimaryKey = 1
    BEGIN
        --Can't create a primary key on a nullable column
        SET @PreserveNullability = 1;
    END;
       
    EXEC tSQLt.Private_ValidateFakeTableParameters @SchemaName,@OrigTableName,@OrigSchemaName;

    --Stash the temporal and history table IDs prior to renaming
    IF @PreserveTemporal = 1 OR @PreservePrimaryKey = 1
    BEGIN
        SELECT @OriginalTableObjectID = object_id, @HistoryTableObjectID = history_table_id
        FROM sys.tables
        WHERE SCHEMA_NAME(schema_id) = PARSENAME(@SchemaName,1) AND name = PARSENAME(@TableName,1);
    END;

    EXEC tSQLt.Private_RenameObjectToUniqueName @SchemaName, @TableName, @NewNameOfOriginalTable OUTPUT;

    SELECT @OrigTableFullName = S.base_object_name
    FROM sys.synonyms AS S 
    WHERE S.object_id = OBJECT_ID(@SchemaName + '.' + @NewNameOfOriginalTable);

    IF(@OrigTableFullName IS NOT NULL)
    BEGIN
        IF(COALESCE(OBJECT_ID(@OrigTableFullName,'U'),OBJECT_ID(@OrigTableFullName,'V')) IS NULL)
        BEGIN
            RAISERROR('Cannot fake synonym %s.%s as it is pointing to %s, which is not a table or view!',16,10,@SchemaName,@TableName,@OrigTableFullName);
        END;
    END;
    ELSE
    BEGIN
        SET @OrigTableFullName = @SchemaName + '.' + @NewNameOfOriginalTable;
    END;

    --Create the fake either with or without NOT NULL constraint
    IF @PreserveNullability = 1
    BEGIN
        EXEC tSQLt.Private_CreateFakeOfTablePreserveNullability @SchemaName, @TableName, @OrigTableFullName, @Identity, @ComputedColumns, @Defaults, @PreserveNullability;
    END;
    ELSE
    BEGIN
        EXEC tSQLt.Private_CreateFakeOfTable @SchemaName, @TableName, @OrigTableFullName, @Identity, @ComputedColumns, @Defaults;
    END;
    
    --Run alter to add primary key
    IF @PreservePrimaryKey = 1
    BEGIN
        EXEC tSQLt.Private_CreatePrimayKey @SchemaName, @TableName, @OriginalTableObjectID;
    END;

    --Alter faked table to a temporal table
    IF @PreserveTemporal = 1
    BEGIN
        EXEC tSQLt.Private_FakeTableAddTemporal @SchemaName, @TableName, @OriginalTableObjectID, @HistoryTableObjectID;
    END;

    EXEC tSQLt.Private_MarkFakeTable @SchemaName, @TableName, @NewNameOfOriginalTable;
END;
GO
