SELECT
COUNT(P.UnitsOnOrder) 'ÜRÜN SATIŞI',
s.Country AS ülke


FROM Suppliers s
JOIN Products p ON p.SupplierID=s.SupplierID
GROUP BY S.Country
ORDER BY [ÜRÜN SATIŞI]