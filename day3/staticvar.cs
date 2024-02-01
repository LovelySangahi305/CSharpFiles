using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class Student
    {
        static string university;
        public int regno;
        public string name;

        static Student()
        {
            university = "ABC University";
        }

        public void GetDetails()
        {
            Console.WriteLine("Enter regno");
            regno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
        }
        public void Display()
        {
            Console.WriteLine($"Regno : {regno} Name : {name} University : {university}");
        }
    }
}
