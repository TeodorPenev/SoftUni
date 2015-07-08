CREATE FUNCTION ufnNewSum(@Sum float, @YearlyIntRate float, @Months int)
RETURNS float
AS
BEGIN
	DECLARE @NewSum float
	SELECT @NewSum = POWER(@Sum*(1+(@YearlyIntRate/12)),@Months);
	IF(@NewSum IS NULL)
		SET @NewSum = 0;
	RETURN @NewSum;
END;
GO

-- Test the created function 
SELECT p.FirstName, dbo.ufnNewSum(a.Balance, 1.4, 1)
FROM Persons p
JOIN Accounts a
ON a.PersonID = p.id
GO