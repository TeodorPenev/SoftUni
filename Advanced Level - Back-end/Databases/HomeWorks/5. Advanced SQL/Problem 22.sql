 INSERT INTO Users(FullName, Username, Password)
 SELECT ((e.FirstName + ' ' + e.LastName)),
		(SUBSTRING(e.FirstName, 0, 2) + LOWER(e.LastName)),
		(SUBSTRING(e.FirstName, 0, 2) + LOWER(e.LastName))
 FROM Employees e
