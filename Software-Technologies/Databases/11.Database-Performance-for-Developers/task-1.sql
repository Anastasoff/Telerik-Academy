USE [master]
GO

IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'PerformanceDB')
CREATE DATABASE PerformanceDB
GO

USE [PerformanceDB]
GO

-- THIS CONDITION DO NOT WORK PROPERLY
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name=N'PerformanceDB' and type='U')
CREATE TABLE Dates(
	DateID int IDENTITY NOT NULL,
	DateValue datetime NOT NULL,
	TextValue nvarchar(MAX) NOT NULL,
	CONSTRAINT PK_Dates_DateID PRIMARY KEY (DateID)
)
GO

--

SET NOCOUNT ON
DECLARE @Rows int = 1000

WHILE @Rows > 0
BEGIN
	DECLARE @Text nvarchar(100) = 
		'TextValue ' + 
		CONVERT(nvarchar(100), @Rows) + 
		': ' +
		CONVERT(nvarchar(100), NEWID())
	DECLARE @Date datetime = 
		DATEADD(month, CONVERT(varbinary, newid()) % (50 * 12), GETDATE())

		INSERT INTO Dates(DateValue, TextValue)
		VALUES (@Date, @Text)
	SET @Rows = @Rows - 1
END

SET NOCOUNT OFF

-- WARNING !!!	SLOW OPERATION !!!
-- TRY WITH 10 000 000 ON YOUR RISK !!!
WHILE (SELECT COUNT(*) FROM Dates) < 1000 
BEGIN
	INSERT INTO Dates (DateValue, TextValue)
	SELECT DateValue, TextValue FROM Dates
END

CHECKPOINT; DBCC DROPCLEANBUFFERS;

SELECT DateValue, TextValue
FROM Dates
WHERE DateValue > '01-Jan-2000' AND DateValue < GETDATE()

SELECT COUNT(*) AS [Rows Count] FROM Dates

CHECKPOINT; DBCC DROPCLEANBUFFERS;

-- DELETE FROM Dates