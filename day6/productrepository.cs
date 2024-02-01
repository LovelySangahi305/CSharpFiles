using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6
{
    internal class Productrepository
    {
        public Product[] pr;
        public Productrepository(Product[] pr)
        { this.pr = pr; }
        public void DisplayAllProducts()
        {
            Console.WriteLine($"_____ALL PRODUCT DETAILS : _______");
            foreach (Product p in pr)
            {
                Console.WriteLine($" PID: {p.Pid} , PNAME: {p.Pname} , PROD PRICE {p.Pprice} , PROD CATEGORY : {p.Pcategory}");
            }
            Console.WriteLine("");

        }
        public void DisplayProductsByCategory(string category) //display all products of the category
        {
            Console.WriteLine($"_____SEARCHING THE PRODUCT BY CATEGORY : _______");
            foreach (Product pd in pr)
            {
                if (pd.Pcategory.Equals(category))
                    Console.WriteLine($"PID: {pd.Pid} , PNAME: {pd.Pname} , PROD PRICE {pd.Pprice} , PROD CATEGORY : {pd.Pcategory}");
            }
            Console.WriteLine("");
        }
            public void DisplayProductByPrice(float price)  //display all products > then the Price
            {
            Console.WriteLine(" ");
            Console.WriteLine($"_____SEARCHING THE PRODUCT BY PRICE : _______");
            foreach (Product pt in pr)
            {
                if ((pt.Pprice)>(price))
                    Console.WriteLine($"PID: {pt.Pid} , PNAME: {pt.Pname} , PROD PRICE {pt.Pprice} , PROD CATEGORY : {pt.Pcategory}");
            }

        }
        }
    }
