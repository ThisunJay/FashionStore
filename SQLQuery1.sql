﻿CREATE TABLE Customers (
	c_id int identity primary key,
	FirstName varchar(50) not null,
	LastName varchar(50) not null,
	email varchar(100) not null,
	c_address varchar(100) not null
);

CREATE TABLE Suppliers (
	s_id int identity primary key,
	s_name varchar(100) not null,
	email varchar(100) not null,
	s_address varchar(100) not null
);

drop table Suppliers

CREATE PROCEDURE Customers_Insert @FirstName varchar(50), @LastName varchar(50), @email varchar(100), @c_address varchar(100)
AS
Begin
	INSERT INTO Customers (FirstName, LastName, email, c_address) VALUES (@FirstName, @LastName, @email, @c_address)
END
--------------------------------------------------------------------

CREATE PROCEDURE Suppliers_Insert @s_name varchar(100), @email varchar(100), @s_address varchar(100)
AS
Begin
	INSERT INTO Suppliers (s_name, email, s_address) VALUES (@s_name, @email, @s_address)
END

CREATE TABLE Employees (
	e_id int identity primary key,
	e_name varchar(100) not null,
	nic varchar(50) not null,
	e_address varchar(100) not null,
	e_contactNumber char(10) not null,
	e_jobrole varchar(50) not null
);

CREATE PROCEDURE Employees_Insert @e_name varchar(100), @nic varchar(50), @e_address varchar(100), @e_contactNumber char(10), @e_jobrole varchar(50)
AS
Begin
	INSERT INTO Employees(e_name, nic, e_address, e_contactNumber, e_jobrole) VALUES (@e_name, @nic, @e_address, @e_contactNumber, @e_jobrole)
END

select * from Employees

CREATE TABLE Items (
	i_id int identity primary key,
	itemCode varchar(50) not null,
	itemName varchar(50) not null,
	itemType varchar(50) not null,
	itemDes varchar(100) not null
);

CREATE PROCEDURE Items_Insert @itemCode varchar(50), @itemName varchar(50), @itemType varchar(50), @itemDes varchar(50)
AS
Begin
	INSERT INTO Items(itemCode, itemName, itemType, itemDes) VALUES (@itemCode, @itemName, @itemType, @itemDes)
END

CREATE TABLE TestData (
	id int identity primary key,
	i_name varchar(50),
	i_date datetime
);

INSERT INTO TestData (i_name, i_date) VALUES ('Thisun', '4/24/2020 10:24:41 PM')

select * from TestData

CREATE TABLE Patterns (
	p_id int identity primary key,
	p_boardNumber varchar(50),
	p_date datetime,
	p_image varchar(70)
);

CREATE PROCEDURE Patterns_Insert @p_boardNumber varchar(50), @p_date datetime, @p_image varchar(70)
AS
Begin
	INSERT INTO Patterns(p_boardNumber, p_date, p_image) VALUES (@p_boardNumber, @p_date, @p_image)
END

select * from Patterns