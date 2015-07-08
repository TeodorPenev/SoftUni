select d.Name, e.JobTitle, e.FirstName, min(Salary) from Employees e
join Departments d
on e.DepartmentID=d.DepartmentID
group by d.Name, e.JobTitle, e.FirstName