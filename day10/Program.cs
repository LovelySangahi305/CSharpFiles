// See https://aka.ms/new-console-template for more information
using day10;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

//Console.WriteLine("_____divide by zero exception______");
//Divbyzero obj = new Divbyzero();
//obj.DisplayDetails();

//Console.WriteLine("_____divide by zero exception by handling exception after input ______");
//Divbyzero2 obj2 = new Divbyzero2();
//obj2.DisplayDetails();

//Console.WriteLine("_____divide by zero exception by handling exception in main ______");
//try
//{
//    Divbyzero3 obj3 = new Divbyzero3();
//    obj3.DisplayDetails();
//}
//catch (FormatException fe)
//{
//    Console.WriteLine("Incorrect format");
//    Console.WriteLine(fe.Message);
//}
//catch (DivideByZeroException de)
//{
//    Console.WriteLine("Cannot divide a number by zero");
//    Console.WriteLine(de.Message);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//finally
//{
//    Console.WriteLine("Finally block");
//}

//Console.WriteLine("_____invalid age exception through custom exception ______");
//Voter v = new Voter();
//v.GetDetails();
//v.DisplayDetails();

//Console.WriteLine("_____invalid balance exception through custom exception ______");
//Balance b = new Balance();
//b.GetDetails();
//b.DisplayDetails();

Thread.CurrentThread.Name = "CURRENT THREAD ";
Console.WriteLine($"{Thread.CurrentThread.Name}");

Console.WriteLine("_____displaying threads according to priority ______");
Thread t1 = new Thread(Threadss.Display1);
ThreadStart ts = new ThreadStart(Threadss.Display2); ;
Thread t2 = new Thread(ts);

t2.Priority = ThreadPriority.Highest;

t1.Start();
t2.Start();

Console.WriteLine("______SYNCHRONIZATION MONITOR________");
for (int i = 0; i < 3; i++)
{
    Thread thread = new Thread(new ThreadStart(Synchrmonitor.ThreadMain));
    thread.Name = String.Concat(" Thread - ", i);
    thread.Start();

}
Console.Read();


