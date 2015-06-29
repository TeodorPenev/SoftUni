select e.FirstName, ISNULL(cast(e.ManagerID as nvarchar), 'No manager') 
from Employees e
left join Employees m
on e.ManagerID=m.EmployeeID