using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqtoserver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch = 'y';
            int choice = 0;
            Studentdb obj1 = new Studentdb();

            do
            {
                Console.Clear();
                Console.WriteLine("1.Display all students");
                Console.WriteLine("2.Display student by ID");
                Console.WriteLine("3.Add new Student");
                Console.WriteLine("4.Update Student Marks");
                Console.WriteLine("5.Delete an Student");
                Console.WriteLine("Select an options");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        obj1.GetAllStudent();
                        break;
                    case 2:
                        obj1.GetStudentById();
                        break;
                    case 3:
                        obj1.AddNewStudent();
                        break;
                    case 4:
                        obj1.UpdateMarks();
                        break;
                    case 5:
                        obj1.DeleteStudent();
                        break;
                    default:
                        Console.WriteLine("Invalid options");
                        break;
                }
                Console.WriteLine("Do you want continue");
                ch = Convert.ToChar(Console.ReadLine().ToLower());
            }
            while (ch == 'y');

            Console.ReadLine();
        
    }
    }
}
