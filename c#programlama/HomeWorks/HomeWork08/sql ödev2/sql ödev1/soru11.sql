SELECT
p.ProductName AS 'Ürün adı',
c.CategoryName AS 'Kategori Adı'
FROM Products p
JOIN Categories c ON p.CategoryID=c.CategoryID
ORDER BY [Kategori Adı]