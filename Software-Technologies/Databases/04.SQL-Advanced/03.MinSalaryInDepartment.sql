-- Task 3. Write a SQL query to find the full name, salary and department of the
-- employees that take the minimal salary in their department.
-- Use a nested SELECT statement.

SELECT 
	FirstName + ISNULL(' ' + MiddleName, '') + ' ' + LastName AS [Full Name], 
	Salary,
	d.Name AS [Department Name]
FROM Employees e
	INNER JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
WHERE e.Salary = (
	SELECT MIN(Salary)
	FROM Employees
	WHERE DepartmentID = d.DepartmentID
)
