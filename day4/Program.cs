// See https://aka.ms/new-console-template for more information
using day4;

Console.WriteLine("Hello, World!");

Employee[] emps = new Employee[]
{
    new Employee(){Empid=1,EmpName="Samatha",Designation="Teacher",Department="Accounts"},
    new Employee(){Empid=2,EmpName="Supriya",Designation="HOP",Department="Accounts"},
    new Employee(){Empid=3,EmpName="Sneha",Designation="Accountant",Department="Sales"},
    new Employee(){Empid=4,EmpName="Smruthi",Designation="HOP",Department="Sales"}

};

//EmployeeRepository emprep = new EmployeeRepository() { employees = emps };

EmployeeRepository emprep = new EmployeeRepository(emps);
//emprep.DisplayDetails();
emprep.DisplayDetails2("Sales");

//Table tb = new Table();
//tb.GetDetails();
//tb.DisplayDetails();

//Pyramid1 p1 = new Pyramid1();
//p1.GetDetails();
//p1.DisplayPyramid();

//Pyramid2 p2 = new Pyramid2();
//p2.GetDetails();
//p2.DisplayPyramid();

//Pyramid3 p3 = new Pyramid3();
//p3.GetDetails();
//p3.DisplayPyramid();

//Namedparam nm = new Namedparam();
//nm.GetDetails();
//nm.DisplayPrice();

//Outparam op= new Outparam();
//op.GetDetails();
//op.DisplayOutput();

//Refparam rp = new Refparam();
//rp.GetDetails();
//rp.DisplayDetails();

Constructor cs = new Constructor();
cs.GetDetails();
cs.DisplayDetails();

Console.WriteLine($"_______FUNCTION OVERLOADING PROGRAM_________");
FuncOverload fv = new FuncOverload();
fv.Add(2,4);
fv.Add(4,6,1);
fv.Add("lovely" , 9);

Console.WriteLine($"_______OPERATOR OVERLOADING PROGRAM_________");
Bank obj = new Bank(); // default constructor executed
obj.GetDetails();
obj.DisplayDetails();

Bank obj1 = new Bank(2.0f); // constructor with one parameter
obj1.GetDetails();
obj1.DisplayDetails();


Bank obj2 = new Bank("Savings", 4.0f); // constructor with two parameter
obj2.GetDetails();
obj2.DisplayDetails();


