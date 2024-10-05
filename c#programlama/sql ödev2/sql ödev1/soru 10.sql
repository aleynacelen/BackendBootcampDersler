SELECT
COUNT(o.OrderID) AS [Toplam Sipariş],
e.EmployeeID AS 'Id'
FROM Orders o
JOIN Employees e ON e.EmployeeID=o.EmployeeID
GROUP BY e.EmployeeID
ORDER BY [Toplam Sipariş]