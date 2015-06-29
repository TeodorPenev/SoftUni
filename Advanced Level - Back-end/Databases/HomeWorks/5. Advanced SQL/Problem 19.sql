INSERT INTO Users(Username, Password, FullName, LastLogin)
	VALUES('Tedo', 'ted123', 'Teodor Penev', GETDATE() - 3),
	      ('Dani', 'dan123', 'Daniel Penev', GETDATE() - 4)     
		  GO
		  	  
INSERT INTO Groups(Name)
	VALUES('Teachers'),
		  ('Cats'),
		  ('Dog')
		  GO