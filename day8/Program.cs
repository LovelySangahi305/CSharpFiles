// See https://aka.ms/new-console-template for more information
using day8;

//Console.WriteLine("________ABSTRACT CLASSES AND METHODS__________");
//int choice;
//Console.WriteLine("1.Child1 SayHello");
//Console.WriteLine("2.Child2 SayHello");
//Console.WriteLine("Select an option");
//choice = Convert.ToInt32(Console.ReadLine());
//Abstrct obj;
//switch (choice)
//{
//    case 1:
//        obj = new Child1();
//        obj.SayAbstract();
//        break;
//    case 2:
//        obj = new Child2();
//        obj.SayAbstract();
//        break;
//    default:
//        Console.WriteLine("Invalid choice");
//        break;
//}


//Console.WriteLine("_____INTERFACE SHAPE IMPLEMENTATION_____");
//int ch;
//Console.WriteLine("1.Area of Circle");
//Console.WriteLine("2.Area of Rectangle");
//Console.WriteLine("3.Area of Square");
//Console.WriteLine("Select an option");
//ch = Convert.ToInt32(Console.ReadLine());
//InterfceShape ish;
//switch (ch)
//{
//    case 1:
//        ish = new Circle();
//        ish.Getdetails();
//        ish.Calarea();
//        ish.Displayarea();
//        break;
//    case 2:
//        ish = new Rectangle();
//        ish.Getdetails();
//        ish.Calarea();
//        ish.Displayarea();
//        break;
//    case 3:
//        ish = new Square();
//        ish.Getdetails();
//        ish.Calarea();
//        ish.Displayarea();
//        break;
//    default:
//        Console.WriteLine("Invalid choice");
//        break;
//}

//Console.WriteLine("_____MULTIPLE INHERITANCE THROUGH INTERFACE IMPLEMENTATION_____");
//Multipleinherit1 obj = new Child4();
//obj.Fun1();
//Multipleinherit2 obj2 = new Child4();
//obj2.Fun2();

//Console.WriteLine("_____EXPLICIT INTERFACE IMPLEMENTATION_____");
//Expinterfce1 ob = new Child3();
//ob.Display();
//Expinterfce2 ob2 = new Child3();
//ob2.Display();

//Console.WriteLine("_____MULTILEVEL INHERITANCE THROUGH INTERFACE IMPLEMENTATION_____");
//Interface5 i5= new Class5();
//i5.Hello();
//Interface6 i6 = new Class5();
//i6.World();

//Console.WriteLine("_____BASIC INHERITANCE _____");
//Child obj = new Child();
//obj.Function2();

//Console.WriteLine("_____DATA PASSING FROM CHILD CONSTRUCTOR TO PARENT CONSTRUCTOR_____");
//Class3 obj2 = new Class3(10, 20, 30);
//obj2.Display3();

////obj3 = new Class6();
////obj3.Display();

//Console.WriteLine("_________ SEALED CLASS PROGRAM_________ ");
//Class4 sl = new Class4();
 
//Console.WriteLine("_________ VIRTUAL FUNCTION PROGRAM_________ ");
//Virtualfun obj4 = new Class7();
//obj4.Display();

//Console.WriteLine("_________ SHADOWING PROGRAM_________ ");
//Shadowing obj5 = new Class10();
//obj5.Display();

//Console.WriteLine(" FILE HANDLING :: READING AND WRITING FROM FILE ");
//Filehandle fh = new Filehandle();
//fh.WriteToFile();
//fh.ReadFromFile();

Console.WriteLine(" FILE HANDLING :: OPEN FILE AND PRINT CONTENT ");
Openfile of = new Openfile();
of.ReadFromFile();