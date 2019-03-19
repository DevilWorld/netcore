CREATE TABLE Customers
(
	 Id	Int Identity(1, 1),
	 CustomerNumber	Int Not Null,
	 ContactLastName	Varchar(50) Not Null,
	 ContactFirstName	Varchar(50) Not Null,
	 Phone	Varchar(50) Null,
	 AddressLine1	Varchar(50) Not Null,
	 AddressLine2	Varchar(50) Null,
	 City	Varchar(50) Not Null,
	 [State]	Varchar(50) Not Null,
	 ZipCode	Varchar(10)	Not Null,
	 Country	Varchar(50)	Not Null,
	 SalesRepEmployeeNumber	Int,
	 CreditLimit	Int,
	 Constraint	pk_customers_customerNumber	Primary Key	(CustomerNumber),
	 Constraint	fk_customers_employee_salesRep	Foreign Key (SalesRepEmployeeNumber)
	 References	Employee (EmployeeNumber)
)