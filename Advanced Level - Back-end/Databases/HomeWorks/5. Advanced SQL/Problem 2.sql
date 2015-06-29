select FirstName, LastName, Salary from Employees
	where Salary >
	(select min(Salary) from Employees) 
	and Salary <= (select min(Salary) * 0.10 + min(Salary) from Employees) 