--Task 25. Write a SQL query to display the average employee salary by department and job title.

SELECT 
	d.Name, 
	e.JobTitle, 
	AVG(e.Salary) AS [Max Salary] 
FROM Employees e
	INNER JOIN Departments d 
		ON d.DepartmentID = e.DepartmentID
GROUP BY d.Name, e.JobTitle