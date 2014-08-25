-- Task 5. Write a SQL query to find the average salary in the "Sales" department.

SELECT
	AVG(e.Salary) AS [Average Salary]
FROM Employees e
	INNER JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'