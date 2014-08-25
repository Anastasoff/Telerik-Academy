--Task 22. Write SQL statements to insert in the Users table the names of all employees from the
--Employees table. Combine the first and last names as a full name. For username use the first
--letter of the first name + the last name (in lowercase). Use the same for the password, and NULL
--for last login time.

INSERT [dbo].[Users](UserName, UserPassword, FullName, LastLogin)
SELECT FirstName + ' ' + LastName,
LOWER(SUBSTRING(FirstName, 0, 1) + LastName + 'salt'),
LOWER(SUBSTRING(FirstName, 0, 1) + LastName),
GETDATE()
FROM [TelerikAcademy].[dbo].[Employees]