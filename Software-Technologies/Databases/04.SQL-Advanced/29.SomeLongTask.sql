--Task 29. Write a SQL to create table WorkHours to store work reports for each employee (employee id, date, task, hours, comments).
--Don't forget to define identity, primary key and appropriate foreign key.
--Issue few SQL statements to insert, update and delete of some data in the table.
--Define a table WorkHoursLogs to track all changes in the WorkHours table with triggers.
--For each change keep the old record data, the new record data and the command (insert / update / delete).

CREATE TABLE WorkHours (
  WorkHourEntryID int IDENTITY,
  EntryDate date NOT NULL,
  Task nvarchar(100) NOT NULL,
  EntryHours int NOT NULL,
  EntryComments nvarchar(200),
  EmployeeID int NOT NULL,
  CONSTRAINT PK_WorkHourEntryID PRIMARY KEY (WorkHourEntryID),
  CONSTRAINT CC_Hours CHECK (EntryHours > 0 AND EntryHours <= 24)
)
GO
ALTER TABLE [dbo].[WorkHours] WITH CHECK ADD CONSTRAINT [FK_WorkHours_Employees] FOREIGN KEY ([EmployeeID])
REFERENCES [dbo].[Employees] ([EmployeeID])
GO
-- Work Hours Logs
CREATE TABLE WorkHoursLogs (
  LogID int IDENTITY,
  WorkHourEntryIDOld int,
  EntryDateOld date,
  TaskOld nvarchar(100),
  EntryHoursOld int,
  EntryCommentsOld nvarchar(200),
  EmployeeIDOld int,
  WorkHourEntryIDNew int,
  EntryDateNew date,
  TaskNew nvarchar(100),
  EntryHoursNew int,
  EntryCommentsNew nvarchar(200),
  EmployeeIDNew int,
  CommandType nvarchar(10),
  CONSTRAINT PK_LogID PRIMARY KEY (LogID),
)
GO
CREATE TRIGGER tr_WorkHoursInsert
ON WorkHours
FOR INSERT
AS
  INSERT INTO WorkHoursLogs (WorkHourEntryIDOld, EntryDateOld, TaskOld, EntryHoursOld, EntryCommentsOld,
  EmployeeIDOld, WorkHourEntryIDNew, EntryDateNew, TaskNew, EntryHoursNew, EntryCommentsNew,
  EmployeeIDNew, CommandType)
    SELECT
      NULL,
      NULL,
      NULL,
      NULL,
      NULL,
      NULL,
      i.WorkHourEntryID,
      i.EntryDate,
      i.Task,
      i.EntryHours,
      i.EntryComments,
      i.EmployeeID,
      'insert'
    FROM WorkHours w
    INNER JOIN inserted i
      ON w.WorkHourEntryID = i.WorkHourEntryID
GO
CREATE TRIGGER tr_WorkHoursUpdate
ON WorkHours
FOR UPDATE
AS
  INSERT INTO WorkHoursLogs (WorkHourEntryIDOld, EntryDateOld, TaskOld, EntryHoursOld, EntryCommentsOld,
  EmployeeIDOld, WorkHourEntryIDNew, EntryDateNew, TaskNew, EntryHoursNew, EntryCommentsNew,
  EmployeeIDNew, CommandType)
    SELECT
      d.WorkHourEntryID,
      d.EntryDate,
      d.Task,
      d.EntryHours,
      d.EntryComments,
      d.EmployeeID,
      i.WorkHourEntryID,
      i.EntryDate,
      i.Task,
      i.EntryHours,
      i.EntryComments,
      i.EmployeeID,
      'update'
    FROM deleted d
    INNER JOIN inserted i
      ON d.WorkHourEntryID = i.WorkHourEntryID
GO
CREATE TRIGGER tr_WorkHoursDelete
ON WorkHours
FOR DELETE
AS
  INSERT INTO WorkHoursLogs (WorkHourEntryIDOld, EntryDateOld, TaskOld, EntryHoursOld, EntryCommentsOld,
  EmployeeIDOld, WorkHourEntryIDNew, EntryDateNew, TaskNew, EntryHoursNew, EntryCommentsNew,
  EmployeeIDNew, CommandType)
    SELECT
      d.WorkHourEntryID,
      d.EntryDate,
      d.Task,
      d.EntryHours,
      d.EntryComments,
      d.EmployeeID,
      NULL,
      NULL,
      NULL,
      NULL,
      NULL,
      NULL,
      'delete'
    FROM deleted d
GO
INSERT INTO WorkHours (EntryDate, Task, EntryHours, EntryComments, EmployeeID)
  VALUES (CONVERT(date, '20140712', 112), 'Slacking', 8, 'no comment', 1),
  (CONVERT(date, '20140511', 112), 'Digging', 4, NULL, 3),
  (CONVERT(date, '20140713', 112), 'More Slacking', 4, 'today i had to work :(', 1),
  (CONVERT(date, '20140611', 112), 'Working', 12, 'more work', 2),
  (CONVERT(date, '20140530', 112), 'Meeting', 5, NULL, 4)
GO
UPDATE WorkHours
SET EntryHours = 8,
    Task = 'Very important work',
    EntryComments = 'so busy, much work, wow'
WHERE EmployeeID = 1
AND EntryDate = CONVERT(date, '20140713', 112)
GO
DELETE FROM WorkHours
WHERE EmployeeID = 4