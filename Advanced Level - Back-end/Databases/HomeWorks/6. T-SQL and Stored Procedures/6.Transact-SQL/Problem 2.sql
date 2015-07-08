CREATE PROCEDURE usp_selectByBalance @MinBalance float
AS
SELECT *
FROM Persons p 
JOIN Accounts a
ON a.PersonID = p.id
WHERE a.Balance > @MinBalance
GO

EXEC usp_selectByBalance @MinBalance = 201
GO