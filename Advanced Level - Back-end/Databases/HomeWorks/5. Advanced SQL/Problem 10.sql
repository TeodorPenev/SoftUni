select t.Name as [Town], d.Name as [Departament], count(*) as [Employees count] from Employees e
join Departments d
on e.DepartmentID = d.DepartmentID
join Addresses a
on e.AddressID = a.AddressID
join Towns t
on a.TownID = t.TownID
group by t.Name, d.Name