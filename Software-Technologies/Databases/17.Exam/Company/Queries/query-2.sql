SELECT 
	d.DepartmentID,
	d.Name
FROM Departments d
LEFT OUTER JOIN Employees e
	ON d.DepartmentID = e.DepartmentID

