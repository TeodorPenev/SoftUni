SELECT e.LastName EmpLastName, m.LastName MgrLastName,t.Name [Address]
FROM Employees e INNER JOIN Employees m
  ON m.EmployeeID = e.ManagerID 
  INNER JOIN Addresses a
  ON e.AddressID = a.AddressID
  INNER JOIN Towns t
  ON a.TownID=t.TownID