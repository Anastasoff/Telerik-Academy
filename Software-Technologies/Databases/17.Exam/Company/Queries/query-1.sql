SELECT
	FirstName + ' ' + LastName AS [Full Name],
	YearSalary AS [Salary]
FROM Employees
WHERE 100000 <= YearSalary AND YearSalary <= 150000
ORDER BY [Salary] ASC