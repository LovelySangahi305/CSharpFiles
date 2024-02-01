use AdventureWorks2019

create function GetSalary2 (@BusinessEntityID int)
returns float
as
begin
             Declare @sal float
            
             select @sal = Rate* 8 * 30 from 
             HumanResources.EmployeePayHistory
            where BusinessEntityID = @BusinessEntityID

             return @sal
end

select GetSalary2 (1)

--OR
select *from [HumanResources].[EmployeePayHistory]
DECLARE @PayRate float 
             SET @PayRate = GetSalary2(12.25) 
             PRINT @PayRate


CREATE FUNCTION fx_Department_Gname -- inline function
                            ( @GrName nvarchar(20) )
                            RETURNS table
                            AS
                            RETURN (
         SELECT * FROM HumanResources.Department         WHERE GroupName=@GrName
                          )
 
SELECT * FROM fx_Department_GName('Manufacturing')

CREATE FUNCTION PayRate (@rate money)  -- multiline
                               RETURNS @table TABLE 
                               (EmployeeID int NOT NULL, 
                               RateChangeDate datetime NOT NULL, 
                               Rate money NOT NULL, 
                               PayFrequency tinyint NOT NULL, 
                               ModifiedDate datetime NOT NULL) 
                               AS 
                               BEGIN 
                                          INSERT @table 
                                          SELECT * FROM 
                            HumanResources.EmployeePayHistory 
                                          WHERE Rate > @rate
                               RETURN 
                               END
 
 
SELECT * FROM PayRate(45)