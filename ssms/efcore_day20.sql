create database capgdb;
use capgdb;
create table product(
ProductID INT PRIMARY KEY identity(1,1),
ProductName VARCHAR(50) NOT NULL,
ProductPrice FLOAT NOT NULL,
Category VARCHAR(50) NOT NULL
)

insert into product values('apple',50,'fruits');
insert into product values('teddy bear',100,'toys');
insert into product values('phone',1500,'electronics');
insert into product values('banana',80,'fruits');
insert into product values('remote car',150,'toys');
insert into product values('grapes',50,'fruits');
insert into product values('laptop',5000,'electronics');
insert into product values('chiku',90,'fruits');
insert into product values('TV',2500,'electronics');
insert into product values('smileyball',20,'toys');

select *from product;