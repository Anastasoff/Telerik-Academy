--Task 30. Start a database transaction, delete all employees from the 'Sales' department
--along with all dependent records from the pother tables. At the end rollback the transaction.

BEGIN TRAN
ALTER TABLE Departments 
	DROP [FK_Departments_Employees]
DELETE FROM Employees
WHERE DepartmentID = (
	SELECT DepartmentID 
	FROM Departments 
	WHERE Name = 'Sales'
)
DELETE FROM Departments
WHERE Name = 'Sales'
ROLLBACK TRAN
GO