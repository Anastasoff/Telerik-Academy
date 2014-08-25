--TASK 21 Write SQL statements to delete some of the records from the Users and Groups tables.

DELETE
FROM Users
WHERE Username = 'stamat'

DELETE
FROM Groups
WHERE Name='Moderators'