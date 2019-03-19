Create Table Orders
(	
	OrderNumber	Int Identity(1, 1),
	OrderDate	Date	Not Null,
	RequiredDate	Date Null,
	ShippedDate		Date Null,
	[Status]	Varchar(15),
	Comments	Varchar(500),
	CustomerNumber	Int,
	Constraint	pk_orders_orderNumber	Primary Key (OrderNumber),
	Constraint fk_orders_customers_cust Foreign Key (CustomerNumber)
	References	dbo.Customers (CustomerNumber)
)