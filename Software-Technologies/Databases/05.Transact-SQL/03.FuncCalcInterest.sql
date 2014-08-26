--Task 3. Create a function that accepts as parameters – sum, yearly interest rate and number of months.
--It should calculate and return the new sum. Write a SELECT to test whether the function works as expected.

USE TransactSQLHW
GO

CREATE FUNCTION ufn_CalculateInterest(@sum money, @interestRate float, @numberOfMonths int)
	RETURNS money
AS
	BEGIN
		RETURN @sum * POWER(1 + @interestRate / 100, @numberOfMonths / 12)
	END
GO

SELECT 
	TransactSQLHW.dbo.ufn_CalculateInterest(Balance, 20, 11) AS [Interest]
FROM Accounts
WHERE PersonID = 2


