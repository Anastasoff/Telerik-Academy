--- 19. Write a SQL query to find all employees and their address.
--- Use equijoins (conditions in the WHERE clause).

SELECT e.FirstName, e.LastName, a.AddressText
FROM Employees e, Addresses a
WHERE e.AddressID = a.AddressID
ORDER BY e.FirstName