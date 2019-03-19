CREATE TABLE Employee
(
	Id	INT Identity(1, 1),
	EmployeeNumber	Int Not Null,
	LastName	Varchar(50) Not Null,
	FirstName	Varchar(50)	Not Null,
	Email		Varchar(100)	Null,
	OfficeCode	Varchar(10),
	ReportsTo	Int,
	JobTitle	Varchar(50),
	Constraint pk_employee_employeenumber	Primary Key	(EmployeeNumber),
	Constraint fk_employee_office_officecode Foreign Key (OfficeCode) 
	References dbo.Office (OfficeCode)
)
