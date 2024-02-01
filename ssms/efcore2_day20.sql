create database studentdb;
use studentdb;
drop table stud;
create table stud
(
StudentID int primary key identity(1,1),
StudentName varchar(50) not null,
StudentGender char(6) not null,
StudentAge int not null
)

insert into stud values('lovely','F',23);
insert into stud values('mansi','F',24);
insert into stud values('amit','M',23);
insert into stud values('nida','F',22);
insert into stud values('abhishek','M',24);
insert into stud values('arjun','M',23);
insert into stud values('ananya','F',22);
insert into stud values('naveen','M',22);

SELECT *FROM STUD;