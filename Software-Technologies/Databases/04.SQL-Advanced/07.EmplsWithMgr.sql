-- Task 7. Write a SQL query to find the number of all employees that have manager.

SELECT
	COUNT(*) AS [Empls with manager]
FROM Employees
WHERE ManagerID IS NOT NULL