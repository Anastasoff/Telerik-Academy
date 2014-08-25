-- Task 19. Write SQL statements to insert several records in the
-- Users and Groups tables. 

INSERT Groups (Name)
VALUES ('Moderator')
GO

INSERT Users (UserName, UserPassword, FullName, LastLogin, GroupID)
VALUES ('bai Ivan', 'th3B0ss', 'Ivan Ivanov', '2014-08-22 14:00:52', 4)
GO

INSERT Users (UserName, UserPassword, FullName, LastLogin, GroupID)
VALUES ('bai Zaprqn', 't3rm1n4t0r', 'Zapri Zaprqnov', '2014-08-22 22:22:22', 3)
GO

