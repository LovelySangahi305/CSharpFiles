using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    internal class Grade
    {
        int m1, m2, m3, m4, m5, avg;
        public void GetDetails()
        {
            Console.WriteLine("Enter the first subject marks : ");
            m1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second subject marks : ");
            m2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third subject marks : ");
            m3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the fourth subject marks : ");
            m4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the fifth subject marks : ");
            m5 = int.Parse(Console.ReadLine());
        }
        private string CalculateGrade(int average)
        {
            average = (m1 + m2 + m3 + m4 + m5) / 5;
            if (average >= 80 && average <= 100)
                return "first";
            else if (average >= 50 && average < 80)
                return "second";
            else if (average >= 30 && average < 50)
                return "third";
            else if (average >= 0 && average < 30)
                return "fail";
            else
                return "invalid marks";
        }
        public void DisplayDetails()
        {
            string c =CalculateGrade(avg);
            Console.WriteLine($"GRADES : {c}");

        }
    }
}
