select 
customer.companyname,
MAX(orders.orderdate) as lastorder,
CAST((
    MAX(CAST(orders.orderdate AS FLOAT))
    + (MAX(CAST(orders.orderdate AS FLOAT)) - MIN(CAST(orders.orderdate AS FLOAT))) / (COUNT(*))
  ) AS DATETIME) as NextPredictedOrder
from StoreSample.Sales.Orders as orders
inner join StoreSample.Sales.Customers as customer on orders.custid = customer.custid
group by customer.companyname