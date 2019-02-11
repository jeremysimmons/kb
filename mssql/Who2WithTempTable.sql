IF OBJECT_ID('tempdb..#who2') IS NOT NULL DROP TABLE #who2
CREATE TABLE #who2 ( [SPID] char(5), [Status] nvarchar(30), [Login] nvarchar(36), [HostName] nvarchar(15), [BlkBy] varchar(5), [DBName] nvarchar(16), [Command] nvarchar(100), [CPUTime] varchar(10), [DiskIO] varchar(7), [LastBatch] varchar(100), [ProgramName] nvarchar(100), [SPID2] char(5), [REQUESTID] char(5) )
INSERT #who2 EXEC sp_who2
SELECT * FROM #who2 WHERE HostName = HOST_NAME()
--SELECT ISNUMERIC(blkby), blkby FROM #who2 WHERE BlkBy LIKE '[0-9]%'