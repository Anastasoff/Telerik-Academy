--Task 2. Create a stored procedure that accepts a number as a parameter and returns all persons
--who have more money in their accounts than the supplied number.

USE TransactSQLHW
GO

CREATE PROC usp_SelectPersonsWithBalanceMoreThan(@minBalance money)
AS
	SELECT
		p.FirstName,
		p.LastName,
		a.Balance
	FROM Persons p
		INNER JOIN Accounts a
			ON p.PersonID = a.PersonID
	WHERE a.Balance > @minBalance
GO

EXEC usp_SelectPersonsWithBalanceMoreThan 500
GO
