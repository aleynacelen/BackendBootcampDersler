--1997 yılının en yüksek cirolu ayını bulun.
SELECT TOP 1 
    YEAR(o.OrderDate) AS Yıl, 
    MONTH(o.OrderDate) AS Ay, 
    SUM(od.Quantity * od.UnitPrice) AS TotalSales
FROM Orders o
JOIN OrderDetails od ON o.OrderID = od.OrderID
WHERE YEAR(o.OrderDate) = 1997
GROUP BY YEAR(o.OrderDate), MONTH(o.OrderDate)
ORDER BY TotalSales DESC;