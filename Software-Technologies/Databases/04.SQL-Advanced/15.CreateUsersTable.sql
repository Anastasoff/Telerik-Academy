-- Task 15. Write a SQL statement to create a table Users. Users should have username,
-- password, full name and last login time. Choose appropriate data types for the table
-- fields. Define a primary key column with a primary key constraint. Define the primary
-- key column as identity to facilitate inserting records. Define unique constraint to
-- avoid repeating usernames. Define a check constraint to ensure the password is at
-- least 5 characters long.

CREATE TABLE Users(
	UserID int IDENTITY NOT NULL,
	UserName nvarchar(20) NOT NULL,
	UserPassword nvarchar(100) NOT NULL,
	FullName nvarchar(100) NOT NULL,
	LastLogin datetime,
	CONSTRAINT PK_Users PRIMARY KEY (UserID),
	CONSTRAINT UC_UserName UNIQUE (UserName),
	CONSTRAINT CC_UserPassword CHECK (LEN(UserPassword) >= 5)
)
GO

SET IDENTITY_INSERT Users ON
GO

INSERT INTO Users (UserID, UserName, UserPassword, FullName, LastLogin)
VALUES (1, N'pesho', N'123456', N'Pesho Peshev', CAST(N'2014-08-23 11:25:44' AS datetime))
GO

INSERT INTO Users (UserID, UserName, UserPassword, FullName, LastLogin)
VALUES (2, N'gosho', N'654321', N'Gosho Goshev', CAST(N'2014-08-23 14:00:33' AS datetime))
GO

INSERT INTO Users (UserID, UserName, UserPassword, FullName, LastLogin)
VALUES (3, N'stamat', N'password', N'Stamat Stamatov', CAST(N'2014-08-22 15:12:00' AS datetime))
GO

SET IDENTITY_INSERT Users OFF
GO