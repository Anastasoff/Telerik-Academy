-- Add an index to speed-up the search by date. Test the search speed (after cleaning the cache).

USE [PerformanceDB]
GO

CREATE INDEX IDX_Dates_DateValue ON Dates(DateValue)

CHECKPOINT; DBCC DROPCLEANBUFFERS;

SELECT DateValue FROM Dates
WHERE DateValue > '01-Jan-2000' AND DateValue < GETDATE()

DROP INDEX IDX_Dates_DateValue ON Dates