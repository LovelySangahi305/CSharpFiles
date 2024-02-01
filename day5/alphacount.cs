using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    internal class Alphacount
    {
        string sentence;
        char ch;
        int count = 0;

        public void GetDetails()
        {
            Console.WriteLine("Enter a string : ");
            sentence = Console.ReadLine();
            Console.WriteLine("Enter the character that you want to count in the sentence : ");
            ch = Convert.ToChar(Console.ReadLine());

        }

        public void DisplayCount()
        {
            string s = sentence.ToLower();
            for(int i=0;i<s.Length; i++) 
            { 
                if (ch == s[i])
                {
                    count++;
                }
            }
            Console.WriteLine($"count of {ch} in {sentence} :{count} ");

        }

    }
}
