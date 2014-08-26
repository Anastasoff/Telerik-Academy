-- Task 8. Using database cursor write a T-SQL script that scans all employees and their addresses and 
-- prints all pairs of employees that live in the same town.

USE TelerikAcademy
GO

DECLARE empCursor CURSOR READ_ONLY FOR
	SELECT
		e1.FirstName + ' ' + e1.LastName AS [First Emp],
		e2.FirstName + ' ' + e2.LastName AS [Second Emp],
		t1.Name
	FROM 
		Employees e1
		JOIN Addresses a1
			ON e1.AddressID = a1.AddressID
		JOIN Towns t1
			ON a1.TownID = t1.TownID,

		Employees e2
		JOIN Addresses a2
			ON e2.AddressID = a2.AddressID
		JOIN Towns t2
			ON a2.TownID = t2.TownID
	WHERE e1.EmployeeID <> e2.EmployeeID

OPEN empCursor
	DECLARE
		@firstEmpName nvarchar(50),
		@secondEmpName nvarchar(50),
		@townName nvarchar(50)
	FETCH NEXT FROM empCursor INTO @firstEmpName, @secondEmpName, @townName
		WHILE @@FETCH_STATUS = 0
			BEGIN
				PRINT @firstEmpName + ', ' + @secondEmpName + ' - ' + @townName
				FETCH NEXT FROM empCursor INTO @firstEmpName, @secondEmpName, @townName
			END
CLOSE empCursor
DEALLOCATE empCursor
GO

