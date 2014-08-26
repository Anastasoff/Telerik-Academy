--Task 5. Add two more stored procedures WithdrawMoney(AccountId, money) and DepositMoney (AccountId, money)
--that operate in transactions.

USE TransactSQLHW
GO

CREATE PROC usp_WithdrawMoney(@accountID int, @amountOfMoney money)
AS
	DECLARE @currentBalance money
	BEGIN
		BEGIN TRAN
		UPDATE Accounts
		SET 
			@currentBalance = Balance - @amountOfMoney,
			Balance = Balance - @amountOfMoney
		WHERE AccountID = @accountID

		IF (@currentBalance < 0)
			ROLLBACK TRAN
		ELSE
			COMMIT TRAN
	END
GO

EXEC usp_WithdrawMoney 3, 555
GO

SELECT
	p.FirstName,
	p.LastName,
	a.Balance
FROM Persons p
	INNER JOIN Accounts a
		ON p.PersonID = a.PersonID

CREATE PROC usp_DepositMoney(@accountID int, @amountOfMoney money)
AS
	BEGIN
		BEGIN TRAN
		UPDATE Accounts
		SET
			Balance = Balance + @amountOfMoney
		WHERE AccountID = @accountID

		IF (@amountOfMoney <= 0)
			ROLLBACK TRAN
		ELSE
			COMMIT TRAN
	END
GO

EXEC usp_DepositMoney 3, 333
GO

SELECT
	p.FirstName,
	p.LastName,
	a.Balance
FROM Persons p
	INNER JOIN Accounts a
		ON p.PersonID = a.PersonID