CREATE PROCEDURE usp_calcNewSum(@AccountId int, @InterestRate float)
	AS
	SELECT dbo.ufnNewSum(a.Balance, @InterestRate, 1)
	FROM Accounts a
	WHERE a.id = @AccountId
GO

EXEC usp_calcNewSum @AccountId = 1, @InterestRate = 1.8;
GO
