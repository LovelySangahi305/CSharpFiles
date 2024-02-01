using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4
{
    internal class Namedparam
    {
        int productid;
        string productname;
        float productprice;

        public void GetDetails()
        {
            Console.WriteLine("Enter productid : ");
            productid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter productname : ");
            productname = Console.ReadLine();
            Console.WriteLine("Enter product price : ");
            productprice = Convert.ToSingle(Console.ReadLine());
        }

        public void Print(int pid, string pname, float price)

        { 
            Console.WriteLine("_______NAMED PARAMETER PROGRAM_________");
            Console.WriteLine($"Product id : {pid} ProductName : {pname} Productprice : {price}");
        }

        public void DisplayPrice()
        {
            Print(pname: productname, price: productprice, pid: productid);
        }

    }
}

