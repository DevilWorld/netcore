CREATE TABLE Office
(
	Id Int Identity(1, 1),
	OfficeCode	Varchar(10) Not Null,
	City	Varchar(50) Not Null,
	Phone	Varchar(50) Not Null,
	AddressLine1	Varchar(50)	Not Null,
	AddressLine2	Varchar(50)	Null,
	[State]		Varchar(50)	Not Null,
	Country		Varchar(50)	Not Null,
	ZipCode		Varchar(10)	Not Null,
	Constraint pk_office_officecode Primary Key ([OfficeCode])
)