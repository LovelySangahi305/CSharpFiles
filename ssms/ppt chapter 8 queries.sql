 select * from HumanResources.Employee
 select *from [Person].[BusinessEntityAddress]
 select *from [Person].[Address]
SELECT BusinessEntityID FROM Person.BusinessEntityAddress	    
WHERE AddressID IN (SELECT AddressID FROM Person.Address WHERE City = 'Bothell')


SELECT BusinessEntityID, JobTitle FROM HumanResources.Employee 
WHERE EXISTS (SELECT * FROM HumanResources.EmployeeDepartmentHistory 
WHERE BusinessEntityID = HumanResources.Employee.BusinessEntityID AND DepartmentID = 4)

SELECT BusinessEntityID, JobTitle 
FROM HumanResources.Employee
WHERE VacationHours >ALL (SELECT VacationHours
FROM HumanResources.Employee WHERE JobTitle
= 'Recruiter')

SELECT BusinessEntityId FROM HumanResources.Employee 
WHERE VacationHours >(SELECT AVG(VacationHours) FROM HumanResources.Employee 
WHERE JobTitle = 'Marketing Assistant')

SELECT DepartmentID FROM HumanResources.EmployeeDepartmentHistory 
WHERE BusinessEntityID = 
(SELECT BusinessEntityID FROM HumanResources.Employee
WHERE BusinessEntityID =
(SELECT EmailAddressID FROM Person.EmailAddress WHERE EmailAddress = 'taylor0@adventure-works.com')
)

select * from [HumanResources].[Department]
--SELECT * FROM EmployeeDetails e
--	WHERE Salary = (SELECT max(Salary) FROM EmployeeDetails WHERE DeptNo = e.DeptNo)

select * from HumanResources.EmployeeDepartmentHistory
SELECT BusinessEntityID, DepartmentID FROM HumanResources.EmployeeDepartmentHistory 
WHERE BusinessEntityID IN(SELECT BusinessEntityID FROM HumanResources.Employee WHERE DepartmentID=6)


CREATE TABLE [dbo].[Borrower](
             [LoanNumber] [int] primary key,
             [BrName] [varchar](50) NULL
)
 
CREATE TABLE [dbo].[Depositor](
             [AccountNumber] [int]primary key,
             [Name] [nchar](10) NULL
)
 
insert into Borrower values (301,'Nora')
insert into Borrower values (305,'Robin')
insert into Borrower values (306,'James')
 
insert into Depositor values(101,'Nora')
insert into Depositor values(103,'Robin')
insert into Depositor values(107,'Nora')
insert into Depositor values(109,'Jennifer')
 
SELECT d.Name, d.AccountNumber, br.LoanNumber --cross apply
FROM Depositor d CROSS APPLY
(SELECT * FROM Borrower b WHERE d.Name = b.BrName) br
 
SELECT d.Name, d.AccountNumber, br.LoanNumber --outer apply
FROM Depositor d OUTER APPLY
(SELECT * FROM Borrower b WHERE d.Name = b.BrName) br
 
SELECT Name FROM Depositor
UNION
SELECT BrName FROM Borrower
 
SELECT Name FROM Depositor
EXCEPT
Select BrName FROM Borrower
 
SELECT Name FROM Depositor
INTERSECT
SELECT BrName FROM Borrower

