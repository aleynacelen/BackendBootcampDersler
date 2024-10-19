SELECT
COUNT(OrderID) AS 'ÜRÜN SATIŞI',
c.CustomerID ıd

FROM  Customers c
JOIN Orders o ON c.CustomerID= o.CustomerID
GROUP  BY c.CustomerID
ORDER BY [ÜRÜN SATIŞI]

