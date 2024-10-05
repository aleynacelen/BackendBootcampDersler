SELECT
p.ProductName AS 'Ürün Adı',
p.UnitPrice AS 'Stok Miktarı'
FROM Products p
WHERE p.UnitPrice<10