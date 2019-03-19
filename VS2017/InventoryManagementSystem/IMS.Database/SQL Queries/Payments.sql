CREATE TABLE Payments
(
	Id Int Identity(1, 1),
	CustomerNumber	Int Not Null,
	ChequeNumber	Varchar(50) Not Null,
	PaymentDate		Date,
	Amount		Decimal(8, 2),
	Constraint pk_payments_cust_chequenumber Primary Key (CustomerNumber, ChequeNumber),
	Constraint fk_payments_custnumber Foreign Key (CustomerNumber)
	References	Customers (CustomerNumber)
)