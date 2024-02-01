use master 
GO --submits query
CREATE DATABASE MyDtb 
ON PRIMARY
 ( NAME='MyDtb_Primary',
   FILENAME='C:\Temp\MyDtb_Prm.mdf',
   SIZE=4MB,
   MAXSIZE=10MB,
   FILEGROWTH=1MB),
FILEGROUP MyDB_FG1
 ( NAME = 'MyDtb_FG1_Dat1',
   FILENAME =
      'C:\Temp\MyDtb_FG1_1.ndf',
   SIZE = 1MB,
   MAXSIZE=10MB,
   FILEGROWTH=1MB),
 ( NAME = 'MyDtb_FG1_Dat2',
   FILENAME =
      'C:\Temp\MyDtb_FG1_2.ndf',
   SIZE = 1MB,
   MAXSIZE=10MB,
   FILEGROWTH=1MB)
LOG ON
( NAME='MyDtb_log',
   FILENAME = 
      'C:\Temp\MyDtb.ldf',
   SIZE=1MB,
   MAXSIZE=10MB,
   FILEGROWTH=1MB)
GO
use MyDtb
create table student(
id int primary key,
Name varchar(50) not null,
Marks int check(marks >0 and marks<100) 
)
INSERT INTO STUDENT VALUES(1, 'LOVELY' ,71)
INSERT INTO STUDENT(ID,NAME,MARKS) VALUES(2, 'MANSI',54)

select *from student;

create table employee
(id int primary key identity(1,1),
name varchar(50) not null,
salary money check(salary>35000),
designation varchar(50) null,
department varchar(50) default 'training'
)
insert into employee(name, salary) values('lovely', 42000)
select * from employee

alter table employee
add emailid varchar(50) unique

insert into employee(name,salary,designation, department, emailid ) values ('nida',39000,'developer','IT','nidakhan@gmail.com')
insert into employee(name,salary,designation, department, emailid ) values ('mansi',40200,'developer','IT','sharmamansi@gmail.com')

select * from employee

create table product
(
id int not null,
Name varchar(50) not null,
price money check(price >500 and price<1000) ,
category varchar(50) check(category = 'toys'or category = 'books'or category = 'electronics')
)
insert into product values(1,'teddybear',540,'toys')
insert into product values(2,'phone',900,'electronics')
insert into product values(3,'c++',970,'books')
insert into product values(4,'java',890,'books')
insert into product values(5,'tv',999,'electronics')
insert into product values(6,'car',560,'toys')

alter table product
drop column id

alter table product
add id int primary key identity(100,100)

select * from product

sp_help product

create database question
use question

create table Category
(
Catid int primary key identity(1,1), 
CName varchar(50) not null,
)

create table Product
(
Pid int IDENTITY(100,1) not null ,
PName varchar(50) not null,
ProductID int NULL,
CONSTRAINT PK_Pid PRIMARY KEY(Pid),
CONSTRAINT FK_Category_Product FOREIGN KEY(ProductID)
REFERENCES Category(Catid)
)

