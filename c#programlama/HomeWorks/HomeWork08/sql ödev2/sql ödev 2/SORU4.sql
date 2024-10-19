SELECT
s.SupplierID AS TedarikçiAdı,
AVG(p.UnitPrice) AS OrtalamaFiyat
FROM Products p
LEFT JOIN Suppliers s ON p.SupplierID=s.SupplierID
GROUP BY s.SupplierID
HAVING
 COUNT(p.ProductID)>10
 ORDER BY ProductID ASC