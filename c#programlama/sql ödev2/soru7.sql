SELECT TOP 5
p.ProductName AS 'Ürün Adı',
P.UnitPrice AS 'Ürün Fiyat'

FROM Products p
ORDER BY P.UnitPrice DESC