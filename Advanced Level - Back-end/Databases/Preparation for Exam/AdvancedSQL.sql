/****** Problem 1 - Script for select empls with min salary command from SSMS  ******/
SELECT FirstName, LastName, Salary
  FROM SoftUni.dbo.Employees
  WHERE Salary in
  (SELECT MIN(Salary)
  From SoftUni.dbo.Employees)

  /****** Problem 2 - Script for select empls that have a salary that is up to 10% higher 
than the minimal salary command from SSMS  ******/
SELECT FirstName, LastName, Salary
	FROM SoftUni.dbo.Employees
	WHERE Salary > 
	(SELECT MIN(Salary) 
	FROM SoftUni.dbo.Employees) AND
	Salary <= (SELECT 0.1 * MIN(Salary) + MIN(Salary)
	FROM SoftUni.dbo.Employees)
	ORDER BY Salary DESC

	/****** Problem 3 - Script for select all empls with min salaries
per department command from SSMS  ******/
SELECT e.FirstName + ' ' + e.LastName as FullName,
e.Salary, d.Name
  FROM SoftUni.dbo.Employees e
  JOIN SoftUni.dbo.Departments d
  ON e.DepartmentID = d.DepartmentID
  WHERE Salary = 
  (SELECT MIN(Salary)
  FROM SoftUni.dbo.Employees 
  WHERE DepartmentID = e.DepartmentID)
  ORDER BY d.DepartmentID

  /****** Problem 4 - Script for select average salary command from SSMS  ******/
SELECT AVG(e.Salary) AS [Average Salary] 
FROM SoftUni.dbo.Employees e
	WHERE e.DepartmentID = 1

	/****** Problem 5 - Script for SelectTopNRows command from SSMS  ******/
SELECT AVG(Salary) as 'Average Salary for Sales Department'
FROM Employees e
JOIN Departments d
ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'

/****** Problem 6 - Script for SelectTopNRows command from SSMS  ******/
SELECT COUNT(*) as 'Sales Employees Count'
FROM Employees e
JOIN Departments d
ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'

/****** Problem 7 - Script for select empls with managers command from SSMS  ******/
SELECT COUNT(*)
FROM Employees 
WHERE ManagerID IS NOT NULL

/****** Problem 8 - Script for select empls without managers command from SSMS  ******/
SELECT COUNT(*)
FROM Employees 
WHERE ManagerID IS NULL


/****** Problem 9 - Script for select all departments and the avg salary command from SSMS  ******/
SELECT 
	d.Name as DepartmentName, 
	AVG(e.Salary) as AverageSalary
	FROM Employees e
	JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
	GROUP BY d.Name


/****** Problem 10 - Script for select count of empls in each department and
for each town command from SSMS  ******/
SELECT 
	t.Name as Town, 
	d.Name as Department,
	COUNT(*) as 'Employees count'
	FROM Employees e
	JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
	JOIN Addresses a
	ON e.AddressID = a.AddressID
	JOIN Towns t
	ON a.TownID = a.TownID
	GROUP BY t.Name, d.Name
	ORDER BY d.Name ASC
	

/****** Problem 11 - Script for select all managers that have exactly 5 employees command from SSMS  ******/
SELECT distinct m.FirstName + ' ' + m.LastName as FullName, 5 as 'Employees Count'
	FROM Employees m
	JOIN Employees e
	ON m.EmployeeID = e.ManagerID
    WHERE 
	(SELECT COUNT(*)
	 FROM Employees x
	 WHERE m.EmployeeID = x.ManagerID) = 5


/****** Problem 12 - Script for select all employees along with their managers command from SSMS  ******/
SELECT 
	e.FirstName + ' ' + e.LastName as FullName,
	ISNULL(m.FirstName + ' ' + m.LastName, '(no manager)') as Manager
	FROM Employees e
	LEFT JOIN Employees m
	ON m.EmployeeID = e.ManagerID


/****** Problem 13 - Script for select the names of all employees whose last name is exactly 
5 characters long command from SSMS  ******/
SELECT FirstName, LastName
FROM Employees
WHERE LEN(LastName) = 5


/****** Problem 14 - Script for select display formatted current date and time command from SSMS  ******/
SELECT CONVERT(NVARCHAR(max), GETDATE(), 104) + ' ' +
		CONVERT(NVARCHAR(max),DATEPART(HOUR, GETDATE())) + ':' +
		CONVERT(NVARCHAR(max),DATEPART(MINUTE, GETDATE())) + ':' +
		CONVERT(NVARCHAR(max),DATEPART(SECOND, GETDATE())) + ':' + 
		CONVERT(NVARCHAR(max),DATEPART(MILLISECOND, GETDATE()))


/****** Problem 15 - Script for create table Users command from SSMS  ******/
CREATE TABLE Users (
	UserID int IDENTITY,
	Username nvarchar(100) NOT NULL UNIQUE CHECK (LEN(Username) > 4),
	Password nvarchar(40) NOT NULL,
	FullName nvarchar(50),
	LastLogin datetime,
	CONSTRAINT PK_Users PRIMARY KEY(UserID)
)
GO


/****** Problem 16 - Script for create view of Users command from SSMS  ******/
CREATE VIEW [PeopleOnlineToday] AS
SELECT *
FROM Users
WHERE DATEPART(YEAR, LastLogin) = DATEPART(YEAR, GETDATE()) 
	AND DATEPART(MONTH, LastLogin) = DATEPART(MONTH, GETDATE()) 
	AND DATEPART(DAY, LastLogin) = DATEPART(DAY, GETDATE()) 
GO


/****** Problem 17 - Script for create table Groups command from SSMS  ******/
CREATE TABLE Groups (
	GroupID int IDENTITY,
	Name nvarchar(100) NOT NULL UNIQUE,
	CONSTRAINT PK_Groups PRIMARY KEY(GroupID)
)
GO

/****** Problem 18 - Script for add column GroupID to Users table command from SSMS  ******/
ALTER TABLE Users
ADD GroupID int 

ALTER TABLE Users
 ADD FOREIGN KEY (GroupID)
 REFERENCES Groups(GroupID)


 /****** Problem 19 - Script for add values to Users and Groups tables command from SSMS  ******/

INSERT INTO Users(Username, Password, FullName, LastLogin)
	VALUES('vanko', 'vanko13S', 'Ivan Petkov', GETDATE() - 3),
	      ('penko', 'penko14S', 'Penko Petkov', GETDATE() - 4),
	      ('ganko', 'ganko15S', 'Ganko Petkov', GETDATE())
		  GO

		  
INSERT INTO Groups(Name)
	VALUES('Tutors'),
		  ('Teachers'),
		  ('Cats'),
		  ('Dawgs')
		  GO


 /****** Problem 20 - Script for update values from Users and Groups tables command from SSMS  ******/
 UPDATE Users
    SET Username = 'UpdatedUsername'
    WHERE UserID = 2
GO

 UPDATE Groups
    SET Name = 'Frogs'
    WHERE GroupID = 2
GO


 /****** Problem 21 - Script for delete values from Users and Groups tables command from SSMS  ******/
  DELETE Groups
    WHERE GroupID = 3
GO

  DELETE Users
    WHERE UserID = 2
GO


 /****** Problem 22 - Script for insert in the Users table the names of all employees from 
 the Employees table command from SSMS  ******/
 INSERT INTO Users(FullName, Username, Password)
 SELECT ((e.FirstName + ' ' + e.LastName)),
		(SUBSTRING(e.FirstName, 0, 2) + LOWER(e.LastName)),
		(SUBSTRING(e.FirstName, 0, 2) + LOWER(e.LastName))
 FROM Employees e
 	WHERE LEN((SUBSTRING(e.FirstName, 0, 1) + LOWER(e.LastName))) > 4
	-- constraint problems occured
	-- userID problems, too


 /****** Problem 23 - Script for change the password to NULL for all users that have not 
 been in the system since 10.03.2010 command from SSMS  ******/
 UPDATE Users SET Password = NULL
	WHERE DATEDIFF(day, LastLogin, CAST('2010-03-10' AS DATE)) > 0


 /****** Problem 24 - Script for delete all users without passwords command from SSMS  ******/
 DELETE FROM Users
  WHERE Password IS NULL


   /****** Problem 25 - Script for display the average employee salary by department 
   and job title command from SSMS  ******/
   SELECT d.Name, e.JobTitle, AVG(e.Salary) as AverageSalary
   FROM Employees e
   JOIN Departments d
   ON e.DepartmentID = d.DepartmentID
   GROUP BY e.JobTitle, e.Salary, d.Name
   ORDER BY AverageSalary DESC


   /****** Problem 26 - Script for display display the minimal employee salary by department
    and job title along with the name of some of the employees that take itcommand from SSMS  ******/
   SELECT d.Name, e.JobTitle, e.FirstName, MIN(e.Salary) AS MinSalary
   FROM Employees e
   JOIN Departments d
   ON e.DepartmentID = d.DepartmentID
   GROUP BY d.Name, e.JobTitle, e.FirstName
   ORDER BY MinSalary DESC


   /****** Problem 27 - Script for display the town where maximal number of employees work command from SSMS  ******/
	SELECT TOP 1 t.Name, COUNT(t.Name) as NrOfEmployees
	FROM Towns t
	JOIN Addresses a
	ON a.TownID = t.TownID
	JOIN Employees e
	ON e.AddressID = a.AddressID
	GROUP BY t.Name
	ORDER BY NrOfEmployees DESC


	  /****** Problem 28 - Script for display the number of managers from each town command from SSMS  ******/
	  SELECT t.Name, COUNT(t.Name) as NrOfManagers
	  FROM Towns t
	  JOIN Addresses a
	  ON a.TownID = t.TownID
	  JOIN Employees e
	  ON e.AddressID = a.AddressID
	  WHERE e.EmployeeID IN
	  (SELECT DISTINCT ManagerID 
	  FROM Employees)
	  GROUP BY t.Name
	  ORDER BY NrOfManagers DESC


/****** Problem 29 - Script for create table WorkHours to store work reports for each employee command from SSMS  ******/
	CREATE TABLE WorkHours (
	Id int IDENTITY,
	EmployeeID int NOT NULL,
	Date date,
	Task nvarchar(50),
	Hours int,
	Comments nvarchar(50),
	CONSTRAINT PK_WorkHours PRIMARY KEY(Id),
	CONSTRAINT FK_Employees_WorkHours FOREIGN KEY(EmployeeId)
		REFERENCES Employees(EmployeeId)
	)
	GO


/****** Problem 30 - Script for insert, update and delete of some data in the table WorkHours command from SSMS  ******/
-- INSERT
DECLARE @counter int;
	SET @counter = 20;
	WHILE @counter > 0
	BEGIN
		INSERT INTO WorkHours(EmployeeId, Date, Task, Hours)
		VALUES (@counter, GETDATE(), 'TASK: ' + CONVERT(varchar(10), @counter), @counter)
		SET @counter = @counter - 1
	END

--- UPDATE
UPDATE WorkHours
SET Comments = 'Workaholics'
WHERE [Hours] > 9

--- DELETE
DELETE FROM WorkHours
WHERE EmployeeId IN (1, 10, 11, 12, 13)


/****** Problem 31 - Script for a table WorkHoursLogs to track all changes in the WorkHours table with
 triggers command from SSMS  ******/
CREATE TABLE WorkHoursLogs (
    WorkLogId int,
    EmployeeId Int NOT NULL,
    OnDate DATETIME NOT NULL,
    Task nvarchar(256) NOT NULL,
    Hours Int NOT NULL,
    Comments nvarchar(256),
    [Action] nvarchar(50) NOT NULL,
    CONSTRAINT FK_Employees_WorkHoursLogs
        FOREIGN KEY (EmployeeId)
        REFERENCES Employees(EmployeeId),
    CONSTRAINT [CC_WorkReportsLogs] CHECK ([Action] IN ('Insert', 'Delete', 'DeleteUpdate', 'InsertUpdate'))
) 
GO

--- TRIGGER FOR INSERT
CREATE TRIGGER tr_InsertWorkReports ON WorkHours FOR INSERT
AS
INSERT INTO WorkHoursLogs(WorkLogId, EmployeeId, OnDate, Task, [Hours], Comments, [Action])
    SELECT WorkReportId, EmployeeID, OnDate, Task, [Hours], Comments, 'Insert'
    FROM inserted
GO

--- TRIGGER FOR DELETE
CREATE TRIGGER tr_DeleteWorkReports ON WorkHours FOR DELETE
AS
INSERT INTO WorkHoursLogs(WorkLogId, EmployeeId, OnDate, Task, [Hours], Comments, [Action])
    SELECT WorkReportId, EmployeeID, OnDate, Task, [Hours], Comments, 'Delete'
    FROM deleted
GO

--- TRIGGER FOR UPDATE
CREATE TRIGGER tr_UpdateWorkReports ON WorkHours FOR UPDATE
AS
INSERT INTO WorkHoursLogs(WorkLogId, EmployeeId, OnDate, Task, [Hours], Comments, [Action])
    SELECT WorkReportId, EmployeeID, OnDate, Task, [Hours], Comments, 'InsertUpdate'
    FROM inserted

INSERT INTO WorkHoursLogs(WorkLogId, EmployeeId, OnDate, Task, [Hours], Comments, [Action])
    SELECT WorkReportId, EmployeeID, OnDate, Task, [Hours], Comments, 'DeleteUpdate'
    FROM deleted
GO

--- TEST TRIGGERS
DELETE FROM WorkHoursLogs

INSERT INTO WorkHours(EmployeeId, OnDate, Task, [Hours])
VALUES (25, GETDATE(), 'TASK: 25', 25)

DELETE FROM WorkHours
WHERE EmployeeId = 25

UPDATE WorkHours
SET Comments = 'Updated'
WHERE EmployeeId = 2

--- Start a database transaction, delete all employees from 
--- the 'Sales' department along with all dependent records from 
--- the pother tables. At the end rollback the transaction.

BEGIN TRAN

ALTER TABLE Departments
DROP CONSTRAINT FK_Departments_Employees
GO

DELETE e FROM Employees e
JOIN Departments d
    ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'

--- ROLLBACK TRAN
--- COMMIT TRAN

--- Start a database transaction and drop the table EmployeesProjects.
--- how could you restore back the lost table data?

BEGIN TRANSACTION

DROP TABLE EmployeesProjects

--- ROLLBACK TRANSACTION
--- COMMIT TRANSACTION

--- Find how to use temporary tables in SQL Server. Using temporary 
--- tables backup all records from EmployeesProjects and restore them back 
--- after dropping and re-creating the table.

BEGIN TRANSACTION

SELECT * 
INTO #TempEmployeesProjects 
FROM EmployeesProjects

DROP TABLE EmployeesProjects

SELECT * 
INTO EmployeesProjects
FROM #TempEmployeesProjects;

DROP TABLE #TempEmployeesProjects

--- ROLLBACK TRANSACTION
--- COMMIT TRANSACTION
