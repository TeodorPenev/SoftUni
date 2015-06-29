CREATE TABLE Users (
	UserID int IDENTITY,
	Username nvarchar(100) NOT NULL UNIQUE,
	Password nvarchar(40) NOT NULL CHECK (LEN(Password) > 5),
	FullName nvarchar(50),
	LastLogin datetime,
	CONSTRAINT PK_Users PRIMARY KEY(UserID))