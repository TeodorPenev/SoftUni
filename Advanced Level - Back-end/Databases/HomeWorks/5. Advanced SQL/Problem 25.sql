select d.Name, e.JobTitle, avg(Salary) from Employees e
join Departments d
on e.DepartmentID = d.DepartmentID
group by d.Name, JobTitle