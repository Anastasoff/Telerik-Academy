SELECT e.EmployeeID, e.FirstName + ' '+ e.LastName as EmployeeName, 
	a.AddressText as EmployeeAddress,
	m.EmployeeID as ManagerID, m.FirstName + ' ' + m.LastName as ManagerName
FROM Employees e 
	INNER JOIN Employees m
	ON e.ManagerID = m.EmployeeID
	INNER JOIN Addresses a
	ON e.AddressID = a.AddressID