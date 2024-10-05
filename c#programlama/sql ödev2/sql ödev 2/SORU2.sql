SELECT 
    OrderDetails.ProductID,
    COUNT(DISTINCT Orders.CustomerID) AS BenzersizMusteriSayisi
FROM 
    OrderDetails
JOIN 
    Orders ON OrderDetails.OrderID = Orders.OrderID
GROUP BY 
    OrderDetails.ProductID;