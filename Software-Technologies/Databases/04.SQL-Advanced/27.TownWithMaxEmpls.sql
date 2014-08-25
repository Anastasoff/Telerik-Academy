--Task 27. Write a SQL query to display the town where maximal number of employees work.

SELECT 
	TOP 1 t.Name, 
	COUNT(*)
FROM Employees e
	INNER JOIN Addresses a 
		ON a.AddressID = e.AddressID
	INNER JOIN Towns t 
		ON t.TownID = a.TownID
GROUP BY t.Name
ORDER BY COUNT(*) DESC