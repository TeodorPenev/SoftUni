SELECT e.LastName EmpLastName, m.LastName MgrLastName
FROM Employees e LEFT JOIN Employees m
  ON e.ManagerID = m.EmployeeID
