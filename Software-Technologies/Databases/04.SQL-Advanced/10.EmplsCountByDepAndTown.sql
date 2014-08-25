-- Task 10. Write a SQL query to find the count of all employees in each department
-- and for each town.

SELECT
	d.Name AS [Department Name],
	t.Name AS [Town Name],
	COUNT(e.EmployeeID) AS [Number of Empls]
FROM Employees e
	INNER JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
	INNER JOIN Addresses a
		ON e.AddressID = a.AddressID
	INNER JOIN Towns t
		ON a.TownID = t.TownID
GROUP BY 
	d.Name,
	t.Name
ORDER BY [Number of Empls] DESC