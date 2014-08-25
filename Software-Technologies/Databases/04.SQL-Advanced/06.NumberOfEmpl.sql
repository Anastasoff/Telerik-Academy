-- Task 6. Write a SQL query to find the number of employees in the "Sales" department.

SELECT
	COUNT(*) AS [Number of Empl]
FROM Employees e
	INNER JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'