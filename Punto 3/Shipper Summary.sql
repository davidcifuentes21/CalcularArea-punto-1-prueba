select 
shipers.companyname,
TotalFreight,
SUM(unitprice * qty) as TotalCostShipped,
SUM(qty) as TotalItemsShipped
from StoreSample.Sales.Orders as orders
inner join StoreSample.Sales.Shippers as shipers on orders.shipperid = shipers.shipperid
inner join StoreSample.Sales.OrderDetails as detail on orders.orderid = detail.orderid
left join (
		select 
		companyname,
		SUM(freight) as TotalFreight
		from StoreSample.Sales.Orders as orders
		inner join StoreSample.Sales.Shippers as shipers on orders.shipperid = shipers.shipperid
		group by shipers.companyname
)feright_total on shipers.companyname = feright_total.companyname
group by shipers.companyname, TotalFreight
order by shipers.companyname