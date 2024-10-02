SELECT
o.OrderID AS Id, 
o.OrderDate AS 'Sipariş Tarihi'
FROM Orders o
WHERE YEAR(o.OrderDate) ='1998'


