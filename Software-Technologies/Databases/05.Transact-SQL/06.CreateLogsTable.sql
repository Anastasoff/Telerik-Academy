--Task 6. Create another table – Logs(LogID, AccountID, OldSum, NewSum). Add a trigger to the Accounts table
--that enters a new entry into the Logs table every time the sum on an account changes.

USE TransactSQLHW
GO

CREATE TABLE Logs(
	LogID int IDENTITY,
	AccountID int NOT NULL,
	OldSum money NOT NULL,
	NewSum money NOT NULL
	CONSTRAINT PK_Logs PRIMARY KEY (LogID)
)
GO

ALTER TABLE Logs
ADD CONSTRAINT FK_Logs_Accounts FOREIGN KEY (AccountID)
REFERENCES Accounts(AccountID)
GO

CREATE TRIGGER tr_UpdateAccounts ON Accounts FOR UPDATE
AS
	DECLARE @updatedID int
	SET @updatedID = (SELECT PersonID FROM inserted)
	INSERT INTO Logs(AccountID, OldSum, NewSum)
	VALUES (@updatedID, 
		(SELECT Balance FROM deleted), 
		(SELECT Balance FROM inserted))
GO

-- for test
UPDATE Accounts
SET Balance = 100
WHERE AccountID = 1