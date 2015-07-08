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
