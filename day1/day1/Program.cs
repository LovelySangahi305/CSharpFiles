using System;

// 1. STUDENT DETAILS ACCEPT AND PRINT
public class Student
{

    string name;
    int age;

    public void GetStudentName()
    {
        Console.WriteLine(" enter your name : ");
        name = Console.ReadLine();
        Console.WriteLine(" enter your age : ");
        age = Convert.ToInt32(Console.ReadLine());
    }

    public void PrintStudentName()
    {
        Console.WriteLine($"Student name :  {name}");
        Console.WriteLine($"Student Age :  {age}");
    }
}

// 2. SQUARE OF A NUMBER 

public class Square
{
    int number;
    public void GetNumber()
    {
        Console.WriteLine(" enter your number whose square who want : ");
        number = Convert.ToInt32(Console.ReadLine());
    }

    public void PrintNumber()
    {
        Console.WriteLine($"Square of number is :  {number * number}");
    }
}

// 3. ACCEPTS CENTIGRADE AND PRINTS FARENHEIT

public class CtoF
{

    int centigrade;

    public void GetCentigrade()
    {
        Console.WriteLine(" Enter Centigrade : ");
        centigrade = Convert.ToInt32(Console.ReadLine());
    }

    public void Printfarenheit()
    {
        Console.WriteLine($"Farenheit of number is :  {((9.0 / 5.0) * centigrade) + 32.0}");
    }
}


// 4. PRINTS ADD,SUBSTRACT,MULTIPLY,DIVIDE

public class Moperations
{
    int a, b;
    public void GetNumber()
    {
        Console.WriteLine(" enter the first number : ");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine(" enter the second number : ");
        b = int.Parse(Console.ReadLine());
    }

    public void Printoperations()
    {
        Console.WriteLine($"Addition of {a} and {b} is :  {a + b}");
        Console.WriteLine($"Subtraction of {a} and {b} is :  {a - b}");
        Console.WriteLine($"Multiplication of {a} and {b} is :  {a * b}");
        Console.WriteLine($"Division of {a} and {b} is :  {a / b}");
    }
}

// 5. ACCEPT EMPID, NAME,DESIGNATION,DEPARTMENT AND PRINT THE SAME

public class Emp
{
    String ename, edesignation, edepartment;
    int eid;

    public void GetEdetails()
    {
        Console.WriteLine(" Enter Employee ID : ");
        eid = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" Enter Employee Name : ");
        ename = Console.ReadLine();
        Console.WriteLine(" Enter Employee Designation : ");
        edesignation = Console.ReadLine();
        Console.WriteLine(" Enter Employee Department : ");
        edepartment = Console.ReadLine();
    }

    public void PrintEdetails()
    {
        Console.WriteLine($"ID of an employee is :  {eid}");
        Console.WriteLine($"Name of an employee is :  {ename}");
        Console.WriteLine($"Designation of an employee is :  {edesignation}");
        Console.WriteLine($"Department of an employee is :  {edepartment}");
    }
}


// 6.  ACCEPT PRODUCTID,PRODUCTNAME, PRODUCTPRICE, UNITSPURCHASED
public class Product
{
    string pname;
    int pid, unitpurchased;
    float pprice, bill;

    public void GetProductDetails()
    {
        Console.WriteLine(" Enter Product ID : ");
        pid = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" Enter Product Name : ");
        pname = Console.ReadLine();
        Console.WriteLine(" Enter Product Price : ");
        pprice = float.Parse(Console.ReadLine());
        Console.WriteLine(" Enter Units Purchased : ");
        unitpurchased = Convert.ToInt32(Console.ReadLine());
    }

    public void PrintProductDetails()
    {
        Console.WriteLine($" Product ID :  {pid}");
        Console.WriteLine($"Product Name :  {pname}");
        Console.WriteLine($"Product Price :{pprice}");
        Console.WriteLine($"Number of Units Purchased :  {unitpurchased}");
        Console.WriteLine($"Your Total Bill :  {unitpurchased * pprice}");
    }
}

class mfile
{
    public static void Main(string[] args)
    {
        Console.Write("Hello lovely sangahi ");
        Console.WriteLine(" this is your day1 program");

     Student s1 = new Student();
     s1.GetStudentName();
     s1.PrintStudentName();
     
     Square s2 = new Square();
     s2.GetNumber();
     s2.PrintNumber();
     
     CtoF cf = new CtoF();
     cf.GetCentigrade();
     cf.Printfarenheit();
  
     Moperations m1 = new Moperations();
     m1.GetNumber();
     m1.Printoperations();

     Emp emp = new Emp();
     emp.GetEdetails();
     emp.PrintEdetails();

     Product p = new Product();
     p.GetProductDetails();
     p.PrintProductDetails();
  }
}
