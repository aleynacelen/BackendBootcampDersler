--En az 3 farklı kategoriden ürün sipariş etmiş müşterileri bulun
SELECT
 COUNT( c.CategoryID) AS FarkliKategoriSayisi
FROM Orders o
JOIN OrderDetails od ON o.OrderID=od.OrderID
JOIN Products p ON od.ProductID=p.ProductID
JOIN Categories c ON p.CategoryID=c.CategoryID
GROUP BY o.CustomerID
HAVING
COUNT(c.CategoryID)>3;

