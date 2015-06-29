SELECT AVG(Salary) AS [Average Salary For Department #1] 
FROM Employees 
	WHERE DepartmentID = 1
	GROUP BY DepartmentID

	