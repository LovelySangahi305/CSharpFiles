use AdventureWorks2019
select * from HumanResources.Employee
select BusinessEntityID ,LoginID, JobTitle from HumanResources.Employee
select BusinessEntityID ,LoginID, JobTitle from HumanResources.Employee where JobTitle ='Research and Development Manager'

Select * from HumanResources.Department 
SELECT DepartmentID 'Department Number', Name 'Department Name' FROM HumanResources.Department --own heading in single quotes
SELECT BusinessEntityID, 'Designation: ', JobTitle FROM HumanResources.Employee --string literals
SELECT Name + ' department comes under ' + GroupName + ' group' AS Department FROM HumanResources.Department --concatenation

SELECT * FROM  HumanResources.EmployeePayHistory
SELECT BusinessEntityID, Rate, Per_Day_Rate = 8 * Rate FROM HumanResources.EmployeePayHistory
SELECT * FROM HumanResources.Department WHERE GroupName = 'Research and Development' --selected rows (use where clause)
SELECT BusinessEntityID, NationalIDNumber, JobTitle, VacationHours FROM HumanResources.Employee WHERE VacationHours < 5
SELECT * FROM HumanResources.Department WHERE GroupName = 'Quality Assurance' OR GroupName = 'Manufacturing' 
SELECT BusinessEntityID, VacationHours FROM HumanResources.Employee WHERE VacationHours BETWEEN 20 AND 50 --between 
SELECT BusinessEntityID, JobTitle, LoginID FROM HumanResources.Employee WHERE JobTitle IN ('Recruiter', 'Stocker') --in
SELECT * FROM HumanResources.Department WHERE Name LIKE 'Pro%'
select * from HumanResources.EmployeeDepartmentHistory
SELECT BusinessEntityID, EndDate FROM HumanResources.EmployeeDepartmentHistory WHERE EndDate IS NULL
SELECT GroupName, DepartmentID, Name FROM HumanResources.Department ORDER BY GroupName, DepartmentID
SELECT TOP 10 * FROM HumanResources.Employee
select * from Production.ProductModel
SELECT * FROM Production.ProductModel WHERE Name LIKE 'HL%' -- % means any number of alphabets and _ means single alphabet
select * from Sales.SalesPerson
select TOP 3 * FROM Sales.SalesPerson WHERE Bonus BETWEEN $4000 AND $6000

select * from Person.Person
SELECT Name = Title + ' ' + left(FirstName,1) + ' . ' + LastName FROM Person.Person
SELECT BusinessEntityID, datename(mm, hiredate)+ ', ' + convert(varchar, datepart(yyyy, hiredate)) as 'Joining' FROM HumanResources.Employee
SELECT GETDATE()
SELECT DATEADD(DD,-3, GETDATE()) 
SELECT DATENAME(month, GETDATE()) -- get the current date's month
SELECT DAY(19-01-2024)

select 'minimum rate' = min(Rate) from HumanResources.EmployeePayHistory