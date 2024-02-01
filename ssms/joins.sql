create database organizations
use organizations
create table Department
(
Deptid int Primary Key identity(1000,100) ,
DeptName varchar(50) not null,
Hod varchar(50) not null
)
CREATE table Employee(
EmployeeID int IDENTITY (1,1) NOT NULL,
FirstName nvarchar(50) NOT NULL,
LastName nvarchar(50) NOT NULL,
DepartmentID int NULL,
CONSTRAINT PK_EmployeeID PRIMARY KEY(EmployeeID),
CONSTRAINT FK_Employee_Department FOREIGN KEY(DepartmentID)
REFERENCES Department(Deptid)
)
insert into Department(DeptName,Hod) Values('Sales','Samatha')
insert into Department(DeptName,Hod) Values('Accounts','Priyanka')
insert into Department(DeptName,Hod) Values('Marketing','Smruthi')
insert into Department(DeptName,Hod) Values('IT','Rekha')
insert into Department(DeptName,Hod) Values('Testing','Raghu')

insert into Employee(FirstName,LastName,DepartmentID) values('samatha','Ramakrishna',Null)
insert into Employee(FirstName,LastName,DepartmentID) values('Samadrita','Chaterjee',Null)
insert into Employee(FirstName,LastName,DepartmentID) values('Supriya','Karn',Null)
insert into Employee(FirstName,LastName,DepartmentID) values('Margana','Neelima',Null)
insert into Employee(FirstName,LastName,DepartmentID) values('Rimpa','Satpathi',Null)
insert into Employee(FirstName,LastName,DepartmentID) values('Krishita','Viroja',1000)
insert into Employee(FirstName,LastName,DepartmentID) values('Priyanka','Kanubai Sagar',1000)
insert into Employee(FirstName,LastName,DepartmentID) values('Shruti','Kumari',1100)
insert into Employee(FirstName,LastName,DepartmentID) values('Smruthi','KalpanaDutta',1200)
insert into Employee(FirstName,LastName,DepartmentID) values('Gadde','Apoorva',1200)

select * from Department
select * from Employee

select e1.EmployeeID,e1.FirstName,d1.Deptid,d1.DeptName
from Employee e1 Join Department d1
on d1.Deptid = e1.DepartmentID

select e1.EmployeeID,e1.FirstName,d1.Deptid,d1.DeptName
from Employee e1 left outer Join Department d1
on d1.Deptid = e1.DepartmentID

select e1.EmployeeID,e1.FirstName,d1.Deptid,d1.DeptName
from Employee e1 right outer Join Department d1
on d1.Deptid = e1.DepartmentID

select e1.EmployeeID,e1.FirstName,d1.Deptid,d1.DeptName
from Employee e1 Full outer Join Department d1
on d1.Deptid = e1.DepartmentID

select * from Employee Join Department on Employee.DepartmentID = Department.Deptid

create database shapes  --cross join
use shapes
create table Shape(
shape varchar(50)
)
create table Color
(
color varchar(50)
)
insert into Shape values('Circle')
insert into Shape values('Rectangle')
insert  into Shape values('Line')

insert into Color values('Red')
insert into Color values('Blue')
insert into Color values('Green')
 
select Shape.shape, Color.color
from Shape cross join Color

create table EmpTable
(
empid int primarykey,
empname varchar(50),
managerid int
)
 
insert into EmpTable values(101,'John Doe',100)
insert into EmpTable values(102,'Jane Smith',101)
insert into EmpTable values(103,'Joseph Reid',104)
insert into EmpTable values(104,'Nick Adams',105)
insert into EmpTable values(105,'Isabel Archer',102)
 
SELECT emp.empname as employee, mng.empname as manager
FROM EmpTable emp JOIN EmpTable mng ON
emp.managerid = mng.empid