using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    internal class VowelSwitch
    {
        char alphabet;

        public void GetDetails()
        {
            Console.WriteLine("Enter an alphabet");
            alphabet = Convert.ToChar(Console.ReadLine().ToLower());
        }

        private bool CheckVowel(char ch)
        {
            switch (ch)
            {
                case 'a':
                case 'i':
                case 'o':
                case 'u':
                case 'e':
                    return true;
                    break;
                default:
                    return false;
                    break;
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
