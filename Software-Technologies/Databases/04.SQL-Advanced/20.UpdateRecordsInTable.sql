-- Task 20. Write SQL statements to update some of the records in the
-- Users and Groups tables.

UPDATE Users
SET UserPassword = 'likeAboss'
WHERE UserName = 'pesho'

UPDATE Groups
SET Name = 'Administrator'
WHERE Name = 'Admins'

UPDATE Groups
SET Name = 'Moderators'
WHERE Name = 'Moderator'