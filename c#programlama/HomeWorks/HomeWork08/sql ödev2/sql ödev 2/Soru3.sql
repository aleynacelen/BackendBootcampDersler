SELECT
e.FirstName + ' '+ e.LastName AS ÇalışanİsimSoyİsim,
m.FirstName+ ' '+m.LastName AS YöneticiİsimSoyİsim

FROM Employees e
 LEFT JOIN Employees m ON e.ReportsTo=m.EmployeeID