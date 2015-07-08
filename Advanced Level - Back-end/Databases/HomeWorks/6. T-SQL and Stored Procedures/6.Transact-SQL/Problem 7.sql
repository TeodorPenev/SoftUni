USE SoftUni
GO

CREATE FUNCTION dbo.udf_setOfLettersSelect(
		@Word NVARCHAR(MAX),
        @Pattern NVARCHAR(MAX)
)
RETURNS BIT
AS BEGIN
        DECLARE @index INT = 1;
        WHILE (@index <= LEN(@Word))
        BEGIN
        IF ( @Pattern NOT LIKE '%' + SUBSTRING(@Word, @index, 1) + '%' ) 
		BEGIN  
                RETURN 0
        END
        SET @index = @index + 1
    END
        RETURN 1
END
GO
-- DROP FUNCTION dbo.ufn_setOfLettersSelect
-- DROP FUNCTION dbo.ufn_AllMatchingNames

CREATE FUNCTION ufn_AllMatchingNames(@pattern nvarchar(255))
	RETURNS @MatchingNames TABLE (Name nvarchar(100))
AS
BEGIN 
	INSERT @MatchingNames
	SELECT * FROM
		(SELECT e.FirstName
		FROM Employees e
		UNION 
		SELECT e.LastName
		FROM Employees e
		UNION
		SELECT e.MiddleName
		FROM Employees e
		UNION
		SELECT t.name
		FROM Towns t) as temp(Name)
	WHERE 1 = dbo.udf_setOfLettersSelect(LOWER(Name), @pattern) AND Name IS NOT NULL
	RETURN
END
GO


--Test
SELECT * 
FROM ufn_AllMatchingNames('nvkoayug')
SELECT * 
FROM ufn_AllMatchingNames('remdno')
GO