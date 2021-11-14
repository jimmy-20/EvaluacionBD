CREATE LOGIN AdminNorthWind with password = 'Northwind'
sp_adduser AdminNorthWind, AdminNorthwind
sp_addrolemember db_owner, AdminNorthwind

Create PROCEDURE Show_Recaudate @Year int
AS

if exists (SELECT
           YEAR(OrderDate) as YearOrder
		   FROM
		   Orders
		   WHERE
		   YEAR(OrderDate) = @Year
		   GROUP BY YEAR(OrderDate))
SELECT
p.ProductID as ProductId,
p.ProductName as ProductName,
SUM(od.Quantity) as Quantity,
ROUND(SUM(od.UnitPrice * od.Quantity - od.UnitPrice * od.Quantity * od.Discount),2) as Income
COUNT() as Discount
FROM
Products p
inner join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID
WHERE YEAR(o.OrderDate) = @Year
GROUP BY p.ProductID,p.ProductName
ORDER By p.ProductID Asc

ELSE
SELECT 'Not Found'

SELECT @@SERVERNAME

SELECT * FROM Products
SELECT * FROM Orders
SELECT * FROM [Order Details]

SELECT
YEAR (OrderDate) as YearOrder
FROM
Orders
GROUP BY YEAR(OrderDate)