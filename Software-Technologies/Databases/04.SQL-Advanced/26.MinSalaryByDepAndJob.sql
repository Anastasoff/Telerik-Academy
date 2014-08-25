--Task 26. Write a SQL query to display the minimal employee salary by department and job title
--along with the name of some of the employees that take it.

SELECT 
	d2.Name, 
	e.JobTitle, 
	e.FirstName + ' ' + e.LastName AS Name, 
	e.Salary
FROM Employees e
	INNER JOIN Departments d2 
		ON d2.DepartmentID = e.DepartmentID
WHERE e.Salary IN (
	SELECT MIN(em.Salary)
	FROM Employees em
	INNER JOIN Departments d 
		ON d.DepartmentID = em.DepartmentID
	WHERE d2.DepartmentID = d.DepartmentID 
		AND e.JobTitle = em.JobTitle
	GROUP BY 
		d.Name, 
		em.JobTitle
)