CREATE TABLE Logs(
LogId int IDENTITY,
AccountId int,
OldSum decimal(18,2),
NewSum decimal(18,2),
PRIMARY KEY (LogId),
FOREIGN KEY (AccountId)
REFERENCES Accounts(id)
)
GO

CREATE TRIGGER tr_UpdateLogOnBalance ON Accounts FOR UPDATE
AS
	DECLARE @OldSum float;
	SELECT @OldSum = Balance FROM deleted;

	INSERT INTO Logs(AccountId, OldSum, NewSum)
		SELECT id, @OldSum, Balance
		FROM inserted
GO

-- Test
EXEC usp_WithdrawMoney 2, 200
EXEC usp_DepositMoney 1, 40000

SELECT * FROM Logs
