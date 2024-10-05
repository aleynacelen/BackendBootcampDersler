SELECT
c.CompanyName AS İsim,
C.CustomerID AS Id

FROM Customers c
LEFT JOIN Orders o ON o.CustomerID=c.CustomerID
WHERE o.OrderID IS NULL ;
