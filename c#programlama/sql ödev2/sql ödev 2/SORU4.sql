SELECT

s.SupplierID,
AVG(p.UnitPrice) 
FROM Products p
 JOIN Suppliers s ON p.SupplierID=s.SupplierID
GROUP BY s.SupplierID
HAVING
 COUNT(*)>10
 