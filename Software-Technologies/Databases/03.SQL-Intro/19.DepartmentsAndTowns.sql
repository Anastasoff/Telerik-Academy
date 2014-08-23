--- 22. Write a SQL query to find all departments
--- and all town names as a single list. Use UNION.

SELECT Name
FROM Departments
UNION
SELECT Name
FROM Towns
ORDER BY Name