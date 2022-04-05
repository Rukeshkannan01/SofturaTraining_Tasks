use AdventureWorks2019
go

-- Task 1
select FirstName, LastName 
from Person.Person where Title is not null

-- Task 2
select FirstName,LastName
from Person.Person 
where FirstName like '%a' and LastName like '%a'

-- Task 3
select salesC.CurrencyCode,Name
from Sales.Currency,Sales.CountryRegionCurrency salesC

-- Task 4
select DepartmentID,Name,GroupName,ModifiedDate
into HR_Dept
from HumanResources.Department

-- Task 5
create table Task5_StdList
(
SNo int identity(1,1),
RollNo varchar(10),
FirstName varchar(20),
LastName varchar(20),
LogDate date default getdate()
constraint PrimeSNo primary Key(SNo)
)
insert Task5_StdList(RollNo,FirstName,LastName) values(2022001,'Joseph', 'Watson')
insert Task5_StdList(RollNo,FirstName,LastName) values(2022002,'John', 'West')
insert Task5_StdList(RollNo,FirstName,LastName) values(2022003,'Gary', 'Bates')
insert Task5_StdList(RollNo,FirstName,LastName) values(2022004,'Rachel', 'Brown')
insert Task5_StdList(RollNo,FirstName,LastName) values(2022005,'Robert', 'Gomez')
insert Task5_StdList(RollNo,FirstName,LastName) values(2022006,'Christopher', 'Robinson')
insert Task5_StdList(RollNo,FirstName,LastName) values(2022007,'Emily', 'Chang')
insert Task5_StdList(RollNo,FirstName,LastName) values(2022008,'Laura', 'West')
insert Task5_StdList(RollNo,FirstName,LastName) values(2022009,'Kyle', 'Kelly')
insert Task5_StdList(RollNo,FirstName,LastName) values(2022010,'John', 'Watson')
insert Task5_StdList(RollNo,FirstName,LastName) values(2022011,'Russell', 'Carter')
insert Task5_StdList(RollNo,FirstName,LastName) values(2022012,'George', 'Hall')
insert Task5_StdList(RollNo,FirstName,LastName) values(2022013,'Connie', 'Cervantes')
insert Task5_StdList(RollNo,FirstName,LastName) values(2022014,'Jonathan', 'Cruz')
insert Task5_StdList(RollNo,FirstName,LastName) values(2022015,'Nicole', 'Christopher')
insert Task5_StdList(RollNo,FirstName,LastName) values(2022016,'Paul', 'Walker')
insert Task5_StdList(RollNo,FirstName,LastName) values(2022017,'Mary', 'Jennifer')
insert Task5_StdList(RollNo,FirstName,LastName) values(2022018,'Alan', 'Walker')
insert Task5_StdList(RollNo,FirstName,LastName) values(2022019,'Kevin', 'Brown')
insert Task5_StdList(RollNo,FirstName,LastName) values(2022020,'William', 'Smith')

-- Task 6
select  emph.businessEntityId,AddressTypeID
from Person.BusinessEntityAddress BEad
inner join HumanResources.EmployeeDepartmentHistory emph
on emph.BusinessEntityID=BEad.BusinessEntityID

-- Task 7
select distinct GroupName
from HumanResources.Department

-- Task 8
select phis.StandardCost, sum(ListPrice) ListPrice, sum(phis.standardcost) StandardCost
from Production.ProductCostHistory phis, Production.Product pp 
group by phis.StandardCost

-- Task 9
select  BusinessEntityID,datediff(YEAR,StartDate,EndDate)as YearOnRole
from HumanResources.EmployeeDepartmentHistory

-- Task 10
Select*from Sales.SalesPersonQuotaHistory

select sum(SalesQuota) SalesQuota
from Sales.SalesPersonQuotaHistory
where SalesQuota>5000 and salesquota<100000
group by SalesQuota

-- Task 11
select Max(TaxRate) Max_taxrate
from Sales.SalesTaxRate

-- Task 12
 create view Task12
 as
 select edh.DepartmentID,edh.BusinessEntityID,ShiftID,BirthDate,datediff(year,BirthDate,getdate()) Age
 from HumanResources.EmployeeDepartmentHistory edh
 join HumanResources.Employee emp
 on edh.BusinessEntityID=emp.BusinessEntityID
 join HumanResources.Department dpt
 on edh.DepartmentID=dpt.DepartmentID
 go

 -- Task 13
 create view Name_age
 as
 select*from Task_12
 go

 -- Task 14
select count(*) No_of_rows_hr
from HumanResources.Department,HumanResources.Employee,HumanResources.EmployeeDepartmentHistory,HumanResources.EmployeePayHistory,HumanResources.JobCandidate,HumanResources.Shift
go

 -- Task 15
select max(Rate) MaxRate, Name
from HumanResources.Department dpt
join HumanResources.EmployeeDepartmentHistory eph
on dpt.DepartmentID=eph.DepartmentID
join HumanResources.EmployeePayHistory ephs
on eph.BusinessEntityID=ephs.BusinessEntityID
group by Name

-- Task 16
select FirstName,MiddleName,Title,AddressTypeID,per.businessentityID
from Person.Person per
left outer join Person.BusinessEntityAddress pb
on per.BusinessEntityID=pb.BusinessEntityID
where Title is not null

-- Task 17
select ProductID,LocationID,Shelf 
from Production.ProductInventory
where (ProductID >300 and ProductID <350) and (LocationID like '%50%' or Shelf = 'E')

 -- Task 18
select pin.LocationID,Shelf,Name 
from Production.ProductInventory pin
join Production.Location pl
on pin.LocationID = pl.LocationID

 -- Task 19
select AddressID,AddressLine1,AddressLine2,sp.StateProvinceID,StateProvinceCode,CountryRegionCode
from Person.StateProvince sp
join Person.Address pa
on sp.StateProvinceID = pa.StateProvinceID

 -- Task 20
select currencycode,sum(subtotal) Total,TaxAmt 
from Sales.SalesOrderHeader soh
join Sales.SalesTerritory stt
on soh.TerritoryID = stt.TerritoryID
join Sales.CountryRegionCurrency crc
on stt.CountryRegionCode=crc.CountryRegionCode
group by CurrencyCode,TaxAmt

