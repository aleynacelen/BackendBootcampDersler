SELECT 
    Employees.FirstName + ' ' + Employees.LastName AS CalisanAd,
    SUM(OrderDetails.UnitPrice * OrderDetails.Quantity) AS ToplamSatisTutari
FROM 
    Orders
JOIN 
    Employees ON Orders.EmployeeID = Employees.EmployeeID
JOIN 
    OrderDetails ON Orders.OrderID = OrderDetails.OrderID
GROUP BY 
    Employees.FirstName, Employees.LastName;
    --chatchpt (anladım)