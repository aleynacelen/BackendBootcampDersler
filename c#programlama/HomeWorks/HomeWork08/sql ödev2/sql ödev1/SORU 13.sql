SELECT top 5 

SUM(p.UnitPrice*od.Quantity) AS 'ÜrünS Satışı',
p.ProductName AS 'Ürün ADI'

FROM Products p  JOIN OrderDetails od ON od.ProductID=p.ProductID
GROUP BY ProductName
ORDER BY [ÜrünS Satışı]