SELECT e.FirstName + ' ' + e.LastName AS Names, d.Name, HireDate  FROM Employees e
INNER JOIN Departments d
ON e.DepartmentID = d.DepartmentID
WHERE (d.Name='Finance' OR d.Name='Sales') AND (HireDate BETWEEN '1995-1-1' AND '2005-1-1')