SELECT e.LastName EmpLastName, m.LastName MgrLastName
FROM Employees e INNER JOIN Employees m
  ON e.ManagerID = m.EmployeeID
