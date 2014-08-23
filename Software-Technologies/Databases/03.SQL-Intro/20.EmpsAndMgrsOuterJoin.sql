--- 23. Write a SQL query to find all the employees and the
--- manager for each of them along with the employees that
--- do not have manager. Use right outer join.
--- Rewrite the query to use left outer join.

-- RIGHT OUTER JOIN
SELECT e.EmployeeID, e.FirstName + ' '+ e.LastName as EmployeeName,
m.EmployeeID as ManagerID, m.FirstName + ' ' + m.LastName as ManagerName
FROM Employees m
	RIGHT OUTER JOIN Employees e
	ON m.EmployeeID = e.ManagerID
ORDER BY e.ManagerID

-- LEFT OUTER JOIN
SELECT e.EmployeeID, e.FirstName + ' '+ e.LastName as EmployeeName,
m.EmployeeID as ManagerID, m.FirstName + ' ' + m.LastName as ManagerName
FROM Employees e
	LEFT OUTER JOIN Employees m
	ON e.ManagerID = m.EmployeeID
ORDER BY e.ManagerID