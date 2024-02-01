using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    internal class Palindrome
    {
        string sentence;

        public void GetDetails()
        {
            Console.WriteLine("Enter a string : ");
            sentence = Console.ReadLine();
        }

        public void DisplayPalindrome()
        {
            
            string[] words = sentence.Split(' ');

            foreach (string s in words)
            {
                char[] ch = s.ToCharArray();
                Array.Reverse(ch);

                string k = String.Concat(ch);

                if (k != s)
                {
                    Console.Write($"{k} ");
                }

            }
        }

    }
}

