// See https://aka.ms/new-console-template for more information
using System;
using day7;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("_____GENERIC PROGRAM____!");
        //Accountdetails ad = new Accountdetails();
        //ad.GetData();
        int N = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            string input = Console.ReadLine();
            string[] words = input.Split(' ');

            string decodedString = DecodeString(words);
            Console.WriteLine(decodedString);
        }
    }

    static string DecodeString(string[] words)
    {
        string decoded = "";

        foreach (string word in words)
        {
            string reversed = ReverseWord(word);

            if (!IsPalindrome(reversed))
            {
                decoded += reversed + " ";
            }
        }

        return decoded.Trim();
    }

    static string ReverseWord(string word)
    {
        char[] charArray = word.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    static bool IsPalindrome(string word)
    {
        int left = 0;
        int right = word.Length - 1;

        while (left < right)
        {
            if (word[left] != word[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
}



//List<Book> bookss = new List<Book>{
//new Book(){Bookid=1,Booktitle="IF Tomorrow comes",Bookprice=450,Bookpublisher="ABC"},
//new Book(){Bookid=2,Booktitle="Ikigai",Bookprice=500,Bookpublisher="EFG"},
//new Book(){Bookid=3,Booktitle="The Alchemist",Bookprice=650,Bookpublisher="LMN"},
//new Book(){Bookid=4,Booktitle="Wings of Fire",Bookprice=900,Bookpublisher="wof"},
//new Book(){Bookid=5,Booktitle="Pride and Prejudice",Bookprice=450,Bookpublisher="ABC"},
//new Book(){Bookid=6,Booktitle="Two States",Bookprice=750,Bookpublisher="PQR"},
//};

//Bookrepository obj = new Bookrepository();
//obj.books = bookss;
//obj.DisplayAllBooks();
//obj.DisplayBookByPublisher("ABC");


