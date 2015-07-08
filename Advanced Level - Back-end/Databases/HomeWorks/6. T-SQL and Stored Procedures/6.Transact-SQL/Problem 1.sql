CREATE TABLE Persons 
(id int NOT NULL IDENTITY,
FirstName nvarchar(50) NOT NULL,
LastName nvarchar(50) NOT NULL,
SSN nvarchar(50),
PRIMARY KEY(id))
GO

CREATE TABLE Accounts 
(id int NOT NULL IDENTITY,
PersonID int NOT NULL,
Balance decimal(18,2) DEFAULT 0,
PRIMARY KEY(id),
FOREIGN KEY(PersonId)
REFERENCES Persons(id))
GO

INSERT INTO Persons(FirstName, LastName, SSN)
VALUES ('Stamat', 'Palamarkov', '2323'),
	   ('Gergin', 'Gergov', '6935'),
	   ('Goca', 'Gergova', '22323')
GO

INSERT INTO Accounts(PersonID, Balance)
VALUES (3, 200.34),
	   (2, 34213.4),
	   (1, 4534.6)
GO

CREATE PROCEDURE usp_selectFullName
AS
SELECT FirstName + ' ' + LastName as FullName
FROM Persons
GO

EXEC usp_selectFullName;
GO