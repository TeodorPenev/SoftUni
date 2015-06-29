select d.Name as [Department], avg(Salary) as [Average Salary] from Employees e
join Departments d
on e.DepartmentID=d.DepartmentID
group by d.Name