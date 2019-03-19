Create Table OrderDetails
(
	Id Int Identity(1, 1),
	OrderNumber	Int Not Null,
	ProductCode Varchar(15) Not NUll,
	QuantityOrdered	Int Not Null,
	Amount	Decimal(8, 2),
	Constraint pk_orderdetails_order_pCode	Primary Key (OrderNumber, ProductCode),
	Constraint fk_od_orders_oNumber Foreign Key (OrderNumber)
	References Orders (OrderNumber),
	Constraint fk_od_products_pCode Foreign Key (ProductCode)
	References Products (ProductCode)
)