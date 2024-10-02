SELECT
COUNT(O.OrderID) AS 'Sipariş Sayısı',
s.ShipperID AS isim
FROM Shippers s
JOIN Orders o ON o.ShipVia=s.ShipperID
GROUP by s.ShipperID
ORDER BY [Sipariş Sayısı]
