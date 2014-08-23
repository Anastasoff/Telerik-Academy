--- 20. Write a SQL query to find all employees along with their manager.

SELECT e.FirstName + ' ' + e.LastName AS EmplName, e.ManagerID,
m.FirstName + ' ' + m.LastName AS MgrName
FROM Employees e INNER JOIN Employees m ON e.ManagerID = m.EmployeeID
ORDER BY e.ManagerID