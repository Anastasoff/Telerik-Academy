--Task 23 Write a SQL statement that changes the password to NULL for all users that have not
--been in the system since 10.03.2010.

UPDATE Users
SET UserPassword = '000000'
WHERE LastLogin <= CAST('2014-08-22 23:59:59' AS datetime)