SELECT  c.CategoryName, 
    COUNT(p.ProductID) AS 'Ürün Miktarı'
FROM Categories c
JOIN  Products p ON  p.CategoryID=c.CategoryID
GROUP BY CategoryName
ORDER BY CategoryName