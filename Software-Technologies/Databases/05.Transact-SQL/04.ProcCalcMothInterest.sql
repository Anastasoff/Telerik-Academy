--Task 4. Create a stored procedure that uses the function from the previous example to give an interest
--to a person's account for one month. It should take the AccountId and the interest rate as parameters.

USE TransactSQLHW
GO

CREATE PROC usp_CalculateMonthInterest(@accountID int, @interestRate float)
AS
	SELECT
		p.FirstName,
		p.LastName,
		a.Balance,
		TransactSQLHW.dbo.ufn_CalculateInterest(a.Balance, @interestRate, 1) AS [MonthInterest]
	FROM Persons p
		INNER JOIN Accounts a
			ON p.PersonID = a.PersonID
	WHERE a.AccountID = @accountID
GO

EXEC usp_CalculateMonthInterest 2, 20