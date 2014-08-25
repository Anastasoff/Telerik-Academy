-- Task 18. Write a SQL statement to add a column GroupID to the table Users.
-- Fill some data in this new column and as well in the Groups table. Write a SQL
-- statement to add a foreign key constraint between tables Users and Groups tables.

-- Add GroupID column in Users table.
ALTER TABLE Users
ADD GroupID int
GO

-- Insert data in Groups table
SET IDENTITY_INSERT Groups ON
GO

INSERT Groups (GroupID, Name)
VALUES (1, N'Admins')
GO

INSERT Groups (GroupID, Name)
VALUES (2, N'Guests')
GO

INSERT Groups (GroupID, Name)
VALUES (3, N'VIP')
GO

SET IDENTITY_INSERT Groups OFF
GO

-- Update GroupID column in Users table
UPDATE Users SET GroupID = 1 WHERE UserID = 1
UPDATE Users SET GroupID = 3 WHERE UserID = 2
UPDATE Users SET GroupID = 2 WHERE UserID = 3 

-- Add foreign key constraint Users --> Groups
ALTER TABLE Users
ADD CONSTRAINT FK_Users_Groups
FOREIGN KEY (GroupID)
REFERENCES Groups(GroupID)
GO