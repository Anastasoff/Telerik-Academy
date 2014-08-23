--- 17. Write a SQL query to find the top 5 best paid employees.

SELECT TOP 5 EmployeeID, FirstName, LastName, Salary
FROM Employees
ORDER BY Salary DESC