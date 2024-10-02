SELECT SUM(o.UnitPrice* o.Quantity) AS 'Sipariş Toplam',
o.OrderID as ıd

FROM OrderDetails o
GROUP BY OrderID
ORDER BY [Sipariş Toplam] DESC