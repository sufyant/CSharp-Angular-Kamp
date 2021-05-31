SELECT Products.ProductID, Products.Price*OrderDetails.Quantity AS ToplamKazanc
FROM Orders
INNER JOIN OrderDetails ON Orders.OrderID = OrderDetails.OrderID
INNER JOIN Products ON Products.ProductID = OrderDetails.ProductID
GROUP BY Products.ProductID
ORDER BY ToplamKazanc DESC;