-- Add a full text index for the text column. 
-- Try to search with and without the full-text index and compare the speed.

USE [PerformanceDB]
GO

SELECT TextValue FROM Dates
WHERE TextValue LIKE '%100%'

CHECKPOINT; DBCC DROPCLEANBUFFERS;

CREATE FULLTEXT CATALOG DatesFullTextCatalog
WITH ACCENT_SENSITIVITY = OFF

CREATE FULLTEXT INDEX ON Dates(TextValue)
KEY INDEX PK_Dates_DateId
ON DatesFullTextCatalog
WITH CHANGE_TRACKING AUTO

CHECKPOINT; DBCC DROPCLEANBUFFERS;

SELECT TextValue FROM Dates
WHERE CONTAINS(TextValue, '%100%')

DROP FULLTEXT INDEX ON Dates
DROP FULLTEXT CATALOG DatesFullTextCatalog