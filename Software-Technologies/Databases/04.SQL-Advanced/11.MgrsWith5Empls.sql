-- Task 11. Write a SQL query to find all managers that have exactly 5 employees.
-- Display their first name and last name.

SELECT 
	m.FirstName,
	m.LastName
FROM Employees m
	INNER JOIN Employees e
		ON m.EmployeeID = e.ManagerID
GROUP BY
	m.FirstName,
	m.LastName
HAVING COUNT(m.EmployeeID) = 5