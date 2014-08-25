-- Task 8. Write a SQL query to find the number of all employees that have no manager.

SELECT
	COUNT(*) AS [Empls without mgr]
FROM Employees
WHERE ManagerID IS NULL