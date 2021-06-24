MySQL Copy Table With Examples
https://www.mysqltutorial.org/mysql-copy-table-data.aspx/

**Summary**_:_ in this tutorial, you will learn how to copy table within the same database or from one database to another using CREATE TABLE and SELECT statements.

## MySQL copy table to a new table

Copying data from an existing table to a new one is very useful in some cases such as backing up data and replicating the production data for testing.

To copy data from a table to a new table, you use [CREATE TABLE](https://www.mysqltutorial.org/mysql-create-table/) and [SELECT](https://www.mysqltutorial.org/mysql-select-statement-query-data.aspx) statements as follows:

`CREATE TABLE new_table 
SELECT col, col2, col3 
FROM
    existing_table;`

Code language: SQL (Structured Query Language) (sql)

First, MySQL creates a new table with the name indicated in the [CREATE TABLE statement](https://www.mysqltutorial.org/mysql-create-table/ "MySQL Create Table"). The structure of the new table is defined by the result set of the `SELECT` statement. Then, MySQL populates data that comes from the `SELECT` statement to the new table.

To copy partial data from an existing table to the new one, you use [WHERE clause](https://www.mysqltutorial.org/mysql-where/ "MySQL WHERE") in the [SELECT statement](https://www.mysqltutorial.org/mysql-select-statement-query-data.aspx "MySQL SELECT") as follows:

`CREATE TABLE new_table 
SELECT col1, col2, col3 
FROM
    existing_table
WHERE
    conditions;`

Code language: SQL (Structured Query Language) (sql)

It is very important to check whether the table you want to create that already exists before creating it. To do so, you use `IF NOT EXIST` clause in the `CREATE TABLE` statement. The complete command of copying data from an existing table to the new one is as follows:

`CREATE TABLE new_table 
SELECT col1, col2, col3 
FROM
    existing_table
WHERE
    conditions;`

Code language: SQL (Structured Query Language) (sql)

Note that the statement above just copies the table and its data. It does not copy other database objects such as [indexes](https://www.mysqltutorial.org/mysql-index/mysql-create-index/), [primary key constraint](https://www.mysqltutorial.org/mysql-primary-key/), [foreign key constraints](https://www.mysqltutorial.org/mysql-foreign-key/), [triggers](https://www.mysqltutorial.org/mysql-triggers.aspx), etc., associated with the table.

To copy data from one table and also all the dependent objects of the table, you use the following statements:

`CREATE TABLE IF NOT EXISTS new_table LIKE existing_table;

INSERT new_table
SELECT * FROM existing_table;`

Code language: SQL (Structured Query Language) (sql)

We need to execute two statements. The first statement [creates a new table](https://www.mysqltutorial.org/mysql-create-table/) `new_table` by duplicating the `existing_table`. The second statement [inserts data](https://www.mysqltutorial.org/mysql-insert-statement.aspx) from the existing table into the `new_table`.

### MySQL copy table examples

The following statement copies data from the `offices` table to a new table named `offices_bk` in the `classicmodels` sample database.

`CREATE TABLE IF NOT EXISTS offices_bk 
SELECT * FROM
    offices;`

Code language: SQL (Structured Query Language) (sql)

We can verify the copy by querying data from the `office_bk` table as follows:

`SELECT
    *
FROM
    offices_bk;`

Code language: SQL (Structured Query Language) (sql)

![MySQL COPY TABLE example](https://sp.mysqltutorial.org/wp-content/uploads/2009/12/MySQL-COPY-TABLE-example.jpg)

![MySQL COPY TABLE example](https://sp.mysqltutorial.org/wp-content/uploads/2009/12/MySQL-COPY-TABLE-example.jpg)

In cases we want to copy the offices in the US only, we can add the `WHERE` clause to the `SELECT` statement as follows:

`CREATE TABLE IF NOT EXISTS offices_usa 
SELECT * 
FROM
    offices
WHERE
    country = 'USA'`

Code language: SQL (Structured Query Language) (sql)

The following statement gets all data from the `offices_usa` table.

`SELECT 
    *
FROM
    offices_usa;`

Code language: SQL (Structured Query Language) (sql)

![MySQL COPY TABLE copy partial data example](https://sp.mysqltutorial.org/wp-content/uploads/2009/12/MySQL-COPY-TABLE-copy-partial-data-example.jpg)

![MySQL COPY TABLE copy partial data example](https://sp.mysqltutorial.org/wp-content/uploads/2009/12/MySQL-COPY-TABLE-copy-partial-data-example.jpg)

Suppose, we want to copy not only the data but also all database objects associated with the `offices` table, we use the following statements:

`CREATE TABLE offices_dup LIKE offices;

INSERT office_dup
SELECT * FROM offices;`

Code language: SQL (Structured Query Language) (sql)

## MySQL copy table to another database

Sometimes, you want to copy a table to a different database. In such cases you use the following statements:

`CREATE TABLE destination_db.new_table 
LIKE source_db.existing_table;

INSERT destination_db.new_table 
SELECT *
FROM source_db.existing_table;`

Code language: SQL (Structured Query Language) (sql)

The first statement creates a new table new\_table in the destination database (destination\_db) by duplicating the existing table (existing\_table) from the source database (source\_db).

The second statements copy data from the existing table in the source database to the new table in the destination database.

Let’s see the following example.

First, we create a database named testdb using the following statement:

`CREATE DATABASE IF NOT EXISTS testdb;`

Code language: SQL (Structured Query Language) (sql)

Second, we create the `offices` table in the `testdb` by copying its structure from the `offices` table in the `classicmodels` database.

`CREATE TABLE testdb.offices LIKE classicmodels.offices;`

Code language: SQL (Structured Query Language) (sql)

Third, we copy data from the classimodels.offices table to testdb.offices table.

`INSERT testdb.offices
SELECT *
FROM classicmodels.offices;`

Code language: SQL (Structured Query Language) (sql)

Let’s verify the data from the `testdb.offices` table.

`SELECT
    *
FROM
    testdb.offices;`

Code language: SQL (Structured Query Language) (sql)

![MySQL COPY TABLE example](https://sp.mysqltutorial.org/wp-content/uploads/2009/12/MySQL-COPY-TABLE-example.jpg)

![MySQL COPY TABLE example](https://sp.mysqltutorial.org/wp-content/uploads/2009/12/MySQL-COPY-TABLE-example.jpg)

In this tutorial, we have shown you various techniques to copy table within a database and from one database to another.