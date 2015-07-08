select t.Name, count(ManagerID) as [Number of managers] from Employees e
join Addresses a
on e.AddressID = a.AddressID
join towns t
on t.TownID = a.TownID
where e.EmployeeID in (SELECT DISTINCT ManagerID 
	  FROM Employees)
group by t.Name	