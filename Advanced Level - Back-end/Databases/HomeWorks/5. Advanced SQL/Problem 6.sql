Select Count(*) as [Sales Employees Count] from Employees e
join Departments d
on e.DepartmentID = d.DepartmentID
where d.Name = 'Sales'