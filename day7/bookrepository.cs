using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace day7
{
    internal class Bookrepository
    {
        public List<Book> books { get; set; }
        public void DisplayAllBooks()
        {
            foreach (Book b in books)
            {
                Console.WriteLine($"{b.Bookid} , {b.Booktitle} , {b.Bookprice} , {b.Bookpublisher}");
            }
        }

        public void DisplayBookByPublisher(string publisher)
        {
            foreach (Book b in books)
            {
                if (b.Bookpublisher == publisher)
                {
                    Console.WriteLine($"{b.Bookid} , {b.Booktitle} , {b.Bookprice},  {b.Bookpublisher}");
                }
            }
        }
    }
}
