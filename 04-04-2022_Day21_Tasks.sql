use AdventureWorks2019
go
-- Task 1
select count(*)
from HumanResources.Department

select sum(Rate) SumOfRate
from HumanResources.EmployeePayHistory

select DATEDIFF(YEAR,StartDate,EndDate) NoOfYears
from HumanResources.EmployeeDepartmentHistory

select DATEADD(day,5,birthdate) BirthOfDate
from HumanResources.Employee

select  CONVERT(int,rate) FloatToInt
from HumanResources.EmployeePayHistory

select left(name,3) Left4
from HumanResources.Department

select firstName,LEN(FirstName)FirstNameLen
from Person.Person

select firstName, REVERSE(FirstName)ReverseName
from Person.Person

go
-- Task 2

create function money_$(@amount varchar(10))
returns varchar(10)
as 
begin
return ('₹' + @amount)
end

go

select dbo.money_$(1000) 

-- Task 3
use Trial
go

create view Task3Table
as
select *
from CandidateTable

go

insert CandidateTable(FirstName,LastName,DateOfBirth,Gender,PhoneNo,CurrentAddress,PermanentAddress) values('Nithin','P','2001-03-26','male',9683214568,'chennai','chennai')

select *
from Task3Table

insert Task3Table(FirstName,LastName,DateOfBirth,Gender,PhoneNo,CurrentAddress,PermanentAddress) values('Kavi','B','2001-07-14','male',9683785618,'chennai','chennai')

go

-- Task 4
create proc proTask4
as 
select *
from TrainingTable

exec protask4

insert TrainingTable values(4,'Rukesh','21','987654321','M')

delete TrainingTable 
where sno = 4

update TrainingTable
set stdName='Kavi'
where stdName='kaviIvak'

go

-- Task 5
select* from Production.Product 

select name
from Production.Product 
where name = 'blade' select daystomanufacture from production.product

-- Task 6
select name
from production.product
where  name like '%all%'  or name like '%any%' or name like '%some%'

select max(weight) as MaxWeight,productmodelid
from  production.product
Group By  productmodelid

-- Task 7
select * from Sales.SalesPerson
select * from Sales.SalesTerritory 
select * from Person.Person

select FirstName, LastName, st.Name
from Person.Person pp
join Sales.SalesPerson sp
on pp.BusinessEntityID = sp.BusinessEntityID
join Sales.SalesTerritory st
on sp.TerritoryID = st.TerritoryID
where st.SalesLastYear = (select max(SalesLastYear) Maxsales from Sales.SalesTerritory )

