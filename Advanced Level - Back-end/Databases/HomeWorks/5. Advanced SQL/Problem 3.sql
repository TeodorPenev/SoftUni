SELECT e.FirstName + ' ' + e.LastName as FullName,
e.Salary, d.Name
  FROM Employees e
  JOIN Departments d
  ON e.DepartmentID = d.DepartmentID
  WHERE Salary = 
  (SELECT MIN(Salary)
  FROM Employees 
  WHERE DepartmentID = e.DepartmentID)
  ORDER BY d.DepartmentID