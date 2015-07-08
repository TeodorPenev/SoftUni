-- INSERT
DECLARE @counter int;
	SET @counter = 20;
	WHILE @counter > 0
	BEGIN
		INSERT INTO WorkHours(EmployeeId, Date, Task, Hours)
		VALUES (@counter, GETDATE(), 'TASK: ' + CONVERT(varchar(10), @counter), @counter)
		SET @counter = @counter - 1
	END

-- UPDATE
UPDATE WorkHours
SET Comments = 'Workaholics'
WHERE [Hours] > 9

-- DELETE
DELETE FROM WorkHours
WHERE EmployeeId IN (1, 10, 11, 12, 13)
