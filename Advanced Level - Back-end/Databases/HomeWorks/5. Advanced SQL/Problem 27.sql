select top 1 t.name, count(e.FirstName) as [Number of employees] from Employees e
join Addresses a
on e.AddressID = a.AddressID
join Towns t
on t.TownID = a.TownID
group by t.Name
order by [Number of employees] desc
