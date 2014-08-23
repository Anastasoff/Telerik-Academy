--- 11. Write a SQL query to find the names of all
--- employees whose first name starts with "SA".

SELECT FirstName, LastName
FROM Employees
WHERE FirstName LIKE 'SA%'
ORDER BY FirstName