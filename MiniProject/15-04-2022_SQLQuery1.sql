create database ProductStore

use ProductStore
go

-- Product Table

create table ProductList
(
ProductID int identity(2201,1),
ProductName varchar(50),
Price money,
MfgDate date default getdate(),
ExpDate date   -- dateadd(month,3,MfgDate)
constraint Prdid_PK primary key(ProductID)
)

select * from ProductList

insert ProductList(ProductName,Price,ExpDate) values('Hide And Seek',30,DATEADD(month,3,getdate()))
insert ProductList(ProductName,Price,ExpDate) values('Good Day',10,DATEADD(month,3,getdate()))
insert ProductList(ProductName,Price,ExpDate) values('Bourbon',15,DATEADD(month,3,getdate()))
insert ProductList(ProductName,Price,ExpDate) values('Dark Fantasy',50,DATEADD(month,3,getdate()))

select ProductID,ProductName,Price,MfgDate,ExpDate
from ProductList

-- Customer Table

create table CustomerList
(
CustomerID int identity(01,1),
Name varchar(20),
Gender char(1),
DoB date,
ContactNo varchar(10),
EmailID varchar(50),
City varchar(20)constraint CheckCity check (city in ('chennai', 'bangalore', 'mumbai', 'hyderabad'))
constraint custID_PK primary key(CustomerID)
)

select * from CustomerList


insert CustomerList(Name,Gender,DoB,ContactNo,EmailID,City) 
values('Nithin','M','2001-01-01','8695795485','nithin001@gmail.com','chennai')


-- Purchase Table

create table PurchaseDetails
(
BillNo int identity(1111,1),
CustomerID int,
ProductID int,
Quantity int,
TotalAmount int,
BillDate date default getdate()
constraint BillNo_PK primary key (BillNo),
constraint CustID_FK foreign key(CustomerID) references CustomerList(CustomerID),
constraint prdID_FK foreign key(ProductID) references ProductLIst(ProductId)
)

select * from PurchaseDetails

select CustomerID,pl.ProductID,ProductName,Price,Quantity,TotalAmount,BillDate
from ProductList as pl 
join PurchaseDetails as pd 
on pl.ProductID = pd.ProductID where BillDate = '2022-04-18'




