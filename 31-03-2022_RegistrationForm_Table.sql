use Trial
go

create table CandidateTable
(
SNo int identity(1,1),
FirstName varchar(20),
MiddleName varchar(20),
LastName varchar(20),
DateOfBirth date ,
Gender varchar(10),
PhoneNo varchar(10),
EmailID varchar(30),
Nationality varchar(10),
Religion varchar(10),
CurrentAddress varchar(100),
PermanentAddress varchar(100),
RegistrationDate date default getdate()
constraint SNo_PK primary key(SNo),
constraint ck_gender check(gender in('male','female','other')),
constraint CK_Nationality check (Nationality in ('Indian'))

)

insert CandidateTable(FirstName,LastName,DateOfBirth,Gender,PhoneNo,EmailID,Nationality,Religion,CurrentAddress,PermanentAddress)
values('Rukeshkumar','K','2001-01-1','male',9654723150,'rukesh@gmail.com','Indian','Hindu','Chennai','Vellore')

select * from CandidateTable
