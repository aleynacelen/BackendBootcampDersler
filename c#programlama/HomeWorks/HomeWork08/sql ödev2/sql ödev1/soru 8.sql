SELECT
COUNT(c.CustomerID) AS 'Satış Toplam',
c.Country AS 'Ülkeler'
FROM Customers c
GROUP BY c.Country
ORDER BY [Satış Toplam]