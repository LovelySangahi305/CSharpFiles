using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    internal class Vowel
    {
        char alphabet;

        public void GetDetails()
        {
            Console.WriteLine("Enter an alphabet");
            alphabet = Convert.ToChar(Console.ReadLine().ToLower());
        }

        private bool CheckVowel(char ch)
        {
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DisplayDetails()
        {
            if (CheckVowel(alphabet))
            {
                Console.WriteLine($"{alphabet} is an vowel");
            }
            else
            {
                Console.WriteLine($"{alphabet} is not a vowel");
            }
        }
    }
}
