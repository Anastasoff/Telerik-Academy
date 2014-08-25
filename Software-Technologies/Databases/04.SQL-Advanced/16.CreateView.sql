-- Task 16. Write a SQL statement to create a view that displays the users from
-- the Users table that have been in the system today. Test if the view works correctly.

CREATE VIEW [Users Logged Today] AS
SELECT * 
FROM Users
WHERE CAST(LastLogin as date) >= CAST(GETDATE() as date)
GO