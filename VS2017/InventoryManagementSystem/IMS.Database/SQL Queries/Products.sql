Create Table Products
(
	Id Int Identity(1, 1),
	ProductCode	Varchar(15)	Not Null,
	[Name]	Varchar(100)	Not Null,
	[Description]	Varchar(200) Null,
	QuantityInStock	Int,
	BuyPrice	Decimal(8, 2),
	MSRP Decimal(8, 2),
	Constraint	pk_products_productCode	Primary Key (ProductCode)	
)