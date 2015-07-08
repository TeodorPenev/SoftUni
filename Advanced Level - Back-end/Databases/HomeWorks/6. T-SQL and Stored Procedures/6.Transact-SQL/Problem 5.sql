CREATE PROCEDURE usp_WithdrawMoney(@AccountId int, @Money float)
AS
	UPDATE Accounts
	SET Balance -= @Money
	FROM Accounts 
	WHERE id = @AccountId
GO

CREATE PROCEDURE usp_DepositMoney(@AccountId int, @Money float)
AS
	UPDATE Accounts
	SET Balance += @Money
	FROM Accounts 
	WHERE id = @AccountId
GO

-- TEST
EXEC usp_WithdrawMoney @AccountId = 1, @Money = 200;
GO

SELECT * 
FROM Accounts
WHERE id = 1

EXEC usp_DepositMoney @AccountId = 1, @Money = 200;
GO