-- make sure connected to master
SELECT * from master.sys.sql_logins

-- username and logins
SELECT A.name as userName, B.name as login, B.Type_desc, default_database_name, B.* 
FROM sys.sysusers A 
    FULL OUTER JOIN sys.sql_logins B 
       ON A.sid = B.sid 
WHERE islogin = 1 and A.sid is not NULL

-- from a user database

SELECT DB_NAME(DB_ID()) as DatabaseName, * FROM sys.sysusers

