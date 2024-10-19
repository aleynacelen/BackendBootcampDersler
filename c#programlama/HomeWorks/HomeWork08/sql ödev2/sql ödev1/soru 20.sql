SELECT 
    YEAR(o.OrderDate) AS Yil,
    MONTH(o.OrderDate) AS Ay, 
SUM(od.UnitPrice*od.Quantity) AS SatısToplam,
o.OrderID AS ıd
FROM Orders o 
JOIN OrderDetails od ON o.OrderID=od.OrderID
GROUP BY 
    YEAR(o.OrderDate), MONTH(o.OrderDate)
ORDER BY 
    Yil, Ay;
    --sor