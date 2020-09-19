use master
go

drop database Cell_On
go

create database Cell_On
go

use Cell_On
go

create table Payment(
	Id int identity not null primary key,
	Name nvarchar(150) not null
)
go

create table Department(
	Id bigint identity not null primary key,
	Name nvarchar(150) not null,
	Salary float not null
)
go

create table Employee(
	Id bigint identity not null primary key,
	Name nvarchar(150) not null,
	Email varchar(150),
	Phone varchar(150) not null,
	[Address] nvarchar(150) not null,
	DOB date not null,
	UserName varchar(150) not null,
	Pass varchar(250) not null,
	DepartmentId bigint not null references Department(Id)
)
go

create table Customer(
	Id bigint identity not null primary key,
	Name nvarchar(150) not null,
	Email varchar(150),
	Phone varchar(150) not null,
	[Address] nvarchar(150) not null,
	UserName varchar(150) not null,
	Pass varchar(250) not null,
	Status bit
)
go

create table Employ(
	CustomerId bigint not null references Customer(Id),
	EmployeeId bigint not null references Employee(Id),
	EmployDate date default getdate(),
	TotalDate int not null,
	Payment int not null references Payment(Id),
	[Status] bit,
	primary key(CustomerId,EmployeeId),
	Unique (EmployeeId,EmployDate)
)
go

create table [Service](
	Id bigint identity not null primary key,
	Name nvarchar(150) not null,
	Price float default(100),
	Content nvarchar(2000) not null
)
go

create table Category(
	Id bigint identity not null primary key,
	Name nvarchar(150) not null,
	Url varchar(150) not null,
	CustomerId bigint not null references Customer(Id)
)
go

create table Product(
	Id bigint not null identity primary key,
	Price float not null,
	Img nvarchar(150) not null,
	Sale bit,
	Discount int not null,
	Infor nvarchar(2000),
	Content nvarchar(2000),
	Url varchar(150) not null,
	Status int default 0,
	CategoryId bigint not null references Category(Id)
)
go

create table Product_Service(
	ProductId bigint not null references Product(Id),
	ServiceId bigint not null references [Service](Id),
	primary key(ProductId,ServiceId)
)
go

create table Contact(
	Id bigint not null identity primary key,
	Email varchar(150),
	Phone varchar(150) not null,
	Content nvarchar(200) not null
)
go

create table [Call](
	Id bigint not null identity primary key,
	[Time] datetime default getdate(),
	EmployeeId bigint not null references Employee(Id),
	Note nvarchar(2000) not null
)
go

create table [Admin](
	Id bigint not null identity primary key,
	Name nvarchar(150) not null,
	Email varchar(150),
	Phone varchar(150) not null,
	[Address] nvarchar(150) not null,
	UserName varchar(150) not null,
	Pass varchar(250) not null,
	Status bit
)
go

create table [Notification](
	Id bigint not null identity primary key,
	Title nvarchar(150),
	Content nvarchar(2000) not null,
	Sender bigint not null references [Admin](Id),
	Employee bigint not null references Employee(Id)
)
go

create table Bill(
	Id bigint not null identity primary key,
	BuyerName nvarchar(150) not null,
	BuyerPhone varchar(150) not null,
	BuyerAddress nvarchar(150) not null,
	DateBuy date not null,
	CustomerId bigint not null references Customer(Id)
)
go

create table Bill_Detailt(
	BillId bigint not null references Bill(Id),
	ProductId bigint not null references Product(Id),
	Quantity int not null,
	primary key(BillId,ProductId)
)
go