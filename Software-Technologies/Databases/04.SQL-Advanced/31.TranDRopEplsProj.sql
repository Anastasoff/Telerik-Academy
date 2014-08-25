--Task 31. Start a database transaction and drop the table EmployeesProjects.
--Now how you could restore back the lost table data?

BEGIN TRAN
DROP TABLE EmployeesProjects
ROLLBACK TRAN