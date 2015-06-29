select avg(Salary) as [Average Salary for Sales Department] from Employees e 
join Departments d
on e.DepartmentID = d.DepartmentID
where d.Name = 'Sales'
