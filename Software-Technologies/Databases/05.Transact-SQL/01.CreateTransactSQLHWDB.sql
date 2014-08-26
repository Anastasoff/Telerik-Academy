--Task 1. Create a database with two tables: Persons(Id(PK), FirstName, LastName, SSN) and
--Accounts(Id(PK), PersonId(FK), Balance). Insert few records for testing. Write a stored
--procedure that selects the full names of all persons.

-- Create TransactSQLHW database
USE [master]
GO

CREATE DATABASE [TransactSQLHW]
GO

USE [TransactSQLHW]
GO

CREATE TABLE Persons(
	PersonID int IDENTITY,
	FirstName nvarchar(50) NOT NULL,
	LastName nvarchar(50) NOT NULL,
	SSN nvarchar(20) NOT NULL,
	CONSTRAINT PK_Persons PRIMARY KEY (PersonID)
)
GO

INSERT INTO Persons (FirstName, LastName, SSN)
VALUES 
	('Pesho', 'Peshev', '123123123'),
	('Gosho', 'Goshov', '234234234'),
	('Stamat', 'Stamat', '345345345')


CREATE TABLE Accounts(
	AccountID int IDENTITY,
	PersonID int NOT NULL,
	Balance money NOT NULL,
	CONSTRAINT PK_Accounts PRIMARY KEY (AccountID)
)
GO

INSERT INTO Accounts (PersonID, Balance)
VALUES 
	(1, 0.0),
	(2, 1000),
	(3, 5000)

-- Add foreign key
ALTER TABLE Accounts
ADD CONSTRAINT FK_Accounts_Persons FOREIGN KEY (PersonID)
REFERENCES Persons(PersonID)

-- Stored procedure
CREATE PROC usp_SelectPersonsFullName
AS
	SELECT
		FirstName + ' ' + LastName AS [FullName]
	FROM Persons
GO

EXEC usp_SelectPersonsFullName