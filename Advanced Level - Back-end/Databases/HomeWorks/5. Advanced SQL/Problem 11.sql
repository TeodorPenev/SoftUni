select e.FirstName, e.LastName, 5 as [Employees count] from Employees e
join Employees m
on e.ManagerID = m.EmployeeID
where
(select Count(*) from Employees x
where e.EmployeeID = x.ManagerID) = 5
