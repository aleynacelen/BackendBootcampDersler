SELECT 
    CustomerID AS ID,
    COUNT(OrderID) AS SiparisSayisi
FROM 
    Orders 
GROUP BY 
    CustomerID
HAVING 
    COUNT(OrderID) >= 5;