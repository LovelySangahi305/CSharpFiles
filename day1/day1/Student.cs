using System;
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

