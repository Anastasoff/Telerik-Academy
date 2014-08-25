-- Task 2. Write a SQL query to find the names and salaries of the employees that
-- have a salary that is up to 10% higher than the minimal salary for the company.

SELECT 
	FirstName, 
	LastName, 
	Salary
FROM Employees
WHERE Salary < (
	1.10 * (
		SELECT MIN(Salary) AS MinSalary
		FROM Employees
	)
)