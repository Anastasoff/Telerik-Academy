--Task 7. Define a function in the database TelerikAcademy that returns all Employee's names (first or middle
--or last name) and all town's names that are comprised of given set of letters. Example 'oistmiahf' will
--return 'Sofia', 'Smith', … but not 'Rob' and 'Guy'.

USE TelerikAcademy
GO

CREATE FUNCTION ufn_NameContainingLetters(@name nvarchar(50), @letters nvarchar(50))
	RETURNS bit
AS
	BEGIN
		DECLARE @contains bit
		SET @contains = 1
		DECLARE @counter int
		SET @contains = 1

		WHILE (LEN(@name) >= @counter)
			BEGIN
				IF (CHARINDEX(SUBSTRING(@name, @counter, 1), @letters) = 0)
					SET @contains = 0
				SET @counter = @counter + 1
			END
		RETURN @contains
	END
GO

CREATE PROC usp_FindFirstNames(@lettersToSearch nvarchar(50))
AS
	DECLARE @valid bit
	SET @valid = 0
		SELECT FirstName
		FROM Employees
		WHERE (
				SELECT dbo.ufn_NameContainingLetters(
				FirstName,
				@LettersToSearch)
		) = 1
GO

CREATE PROC usp_FindMiddleNames(@lettersToSearch nvarchar(50))
AS
	DECLARE @valid bit
	SET @valid = 0
		SELECT MiddleName
		FROM Employees
		WHERE (
				SELECT dbo.ufn_NameContainingLetters(
				MiddleName,
				@LettersToSearch)
		) = 1
GO

CREATE PROC usp_FindLastName(@lettersToSearch nvarchar(50))
AS
	DECLARE @valid bit
	SET @valid = 0
		SELECT LastName
		FROM Employees
		WHERE (
				SELECT dbo.ufn_NameContainingLetters(
				LastName,
				@LettersToSearch)
		) = 1
GO

CREATE PROC usp_FindTowns(@lettersToSearch nvarchar(50))
AS
	DECLARE @valid bit
	SET @valid = 0
		SELECT Name
		FROM Towns
		WHERE 
			1 = (
				SELECT dbo.ufn_NameContainingLetters(
				Name,
				@LettersToSearch)
			)
GO

EXEC dbo.usp_FindFirstNames 'oistmiahf'
EXEC dbo.usp_FindMiddleNames 'oistmiahf'
EXEC dbo.usp_FindLastName 'oistmiahf'
EXEC dbo.usp_FindTowns 'oistmiahf'
GO