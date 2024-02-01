use organizations
select * from Department
select * from Employee
insert into Employee(FirstName, LastName, DepartmentID) values('lovely' ,'sangahi',2000)
delete from Department where Deptid = 1000
delete from Department where Deptid = 1400

use Master
create database neworganization
use neworganization

Create table Department
(
Deptid int Primary Key identity(1000,100) ,
DeptName varchar(50) not null,
Hod varchar(50) not null
)
 
CREATE TABLE Employee(
EmployeeID int IDENTITY (1,1) NOT NULL,
FirstName nvarchar(50) NOT NULL,
LastName nvarchar(50) NOT NULL,
DepartmentID int NULL,
CONSTRAINT PK_EmployeeID PRIMARY KEY(EmployeeID),
CONSTRAINT FK_Employee_Department FOREIGN KEY(DepartmentID)
REFERENCES Department(Deptid) ON Delete set null
)
 
insert into Department(DeptName,Hod) Values('Sales','lakshita')
insert into Department(DeptName,Hod) Values('Accounts','Preesha')
insert into Department(DeptName,Hod) Values('Marketing','Samiksha')
insert into Department(DeptName,Hod) Values('IT','Rekha')
insert into Department(DeptName,Hod) Values('Testing','Raghini')
 
insert into Employee(FirstName,LastName,DepartmentID) values('samatha','Ramakrishna',Null)
insert into Employee(FirstName,LastName,DepartmentID) values('monika','singh',Null)
insert into Employee(FirstName,LastName,DepartmentID) values('sakshi','gupta',Null)
insert into Employee(FirstName,LastName,DepartmentID) values('khan','nida',Null)
insert into Employee(FirstName,LastName,DepartmentID) values('kanishka','S',Null)
 
insert into Employee(FirstName,LastName,DepartmentID) values('lavanya','sharma',1000)
insert into Employee(FirstName,LastName,DepartmentID) values('lovely','sangahi',1000)
insert into Employee(FirstName,LastName,DepartmentID) values('mansi','Kumari',1100)
insert into Employee(FirstName,LastName,DepartmentID) values('lucky','sangahi',1100)
insert into Employee(FirstName,LastName,DepartmentID) values('riya','tewatia',1200)
 
Select * from Department
Select * from Employee
delete from Department where Deptid = 1000
update Employee set DepartmentId = 1300 where EmployeeID=7
update Department set DeptName = 'Business' where Hod='Preesha'
update Employee set LastName = 'chaunwal' where FirstName = 'kanishka'

use AdventureWorks2019
select * from HumanResources.EmployeePayHistory

DECLARE @Rate int -- declare and print variable 
SELECT @Rate = max(Rate)
FROM HumanResources.EmployeePayHistory	
PRINT @Rate
GO

DECLARE @Rate money ---if else loop
SELECT @Rate = Rate FROM 
HumanResources.EmployeePayHistory
WHERE BusinessEntityID = 23
IF @Rate < 15
	PRINT 'Review of the rate is required'
	ELSE
	BEGIN
		PRINT 'Review of the rate is not required'
		PRINT 'Rate = '
		PRINT @Rate
	END
GO

WHILE (SELECT AVG(Rate)+1 FROM HumanResources.EmployeePayHistory) < 20 ----while loop
BEGIN
    UPDATE HumanResources.EmployeePayHistory
    SET Rate = Rate + 1
    FROM HumanResources.EmployeePayHistory
    IF (SELECT max(Rate)+1 FROM
        HumanResources.EmployeePayHistory)>127
    BREAK
    ELSE
    CONTINUE
END
select * from HumanResources.EmployeePayHistory

----stored procedurers
create procedure GetAllEmployees
as
begin
select * from HumanResources.Employee
end

exec GetAllEmployees

use neworganization
create procedure GetEmployees
as
begin
select * from Employee
end

GetEmployees

create procedure GetEmployeesbydept @deptid int
as
begin
select * from Employee
where DepartmentID = @deptid
end

GetEmployeesbydept 1300