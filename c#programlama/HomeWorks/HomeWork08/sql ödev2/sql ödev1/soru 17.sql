SELECT
AVG(c.CategoryID) AS 'ORTALAMA',
p.ProductName as 'Ürün adı'
FROM Categories c
JOIN Products p ON p.CategoryID=c.CategoryID
GROUP BY ProductName
ORDER by[ORTALAMA]