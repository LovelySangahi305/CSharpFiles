using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day11
{
    internal class Linqquery
    {
        int[] arr = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        string[] names = new string[10] { "lovely", "mansi", "nida", "kavita", "anupama", "ekta", "surbhi", "ananya", "anushka", "kirti" };
        public void displayarr()
        {
            Console.WriteLine("DISPLAYING ARRAY THROUGH LINQ SELECT QUERY");
            IEnumerable<int> result = from a in arr
                                      select a;

            foreach (int a in result)
            {
                Console.WriteLine($"{a}");
            }
        }
        public void displayeven()
        {
            Console.WriteLine("DISPLAYING EVEN NUMBERS THROUGH LINQ WHERE AND SELECT QUERY");
            var result = from a in arr
                         where a % 2 == 0
                         select a;

            foreach (int a in result)
            {
                Console.WriteLine($"{a}");
            }
        }
        public void displaygreater()
        {
            Console.WriteLine("DISPLAYING GREATER THROUGH LINQ WHERE AND SELECT QUERY");
            IEnumerable<int> result = from a in arr
                                      where a > 5
                                      select a;

            foreach (int a in result)
            {
                Console.WriteLine($"{a}");
            }
        }
        public void displaynames()
        {
            Console.WriteLine("DISPLAYING NAMES GREATER THAN 5 AND START WITH A THROUGH LINQ WHERE AND SELECT QUERY");
            IEnumerable<string> result = from a in names
                                      where (a.Length > 5) && a.StartsWith('a')
                                      select a;

            foreach (string a in result)
            {
                Console.WriteLine($"{a}");
            }
        }
    }
    internal class Linqmethod
    {
        int[] arr = new int[10] { 11, 22, 32, 44, 53, 66, 75, 88, 97, 100 };
        string[] names = new string[10] { "lovely", "mansi", "nida", "kavita", "anupama", "ekta", "surbhi", "ananya", "anushka", "kirti" };
        public void displayarray()
        {
            Console.WriteLine("DISPLAYING ARRAY THROUGH LINQ  SELECT METHOD");
            IEnumerable<int> result = arr.Select(a => a);
            foreach (int a in result)
            {
                Console.WriteLine($"{a}");
            }
        }
            
        public void displayeven()
        {
            Console.WriteLine("DISPLAYING EVEN NUMBERS THROUGH LINQ WHERE METHOD");
            var result = arr.Where(a => a % 2 == 0);

            foreach (int a in result)
            {
                Console.WriteLine($"{a}");
            }
        }
            

            
        public void displaygreater()
        {
            Console.WriteLine("DISPLAYING GREATER THROUGH LINQ WHERE METHOD");
            IEnumerable<int> result = arr.Where(a => a > 52);

            foreach (int a in result)
            {
                Console.WriteLine($"{a}");
            }
        }
        public void displayNames()
        {
            Console.WriteLine("DISPLAYING NAMES GREATER THAN 5 AND START WITH A THROUGH LINQ WHERE AND SELECT QUERY");
            IEnumerable<string> result = names.Where(a => ((a.Length > 5) && a.StartsWith('a')));
                                        

            foreach (string a in result)
            {
                Console.WriteLine($"{a}");
            }
        }

    }

    }
