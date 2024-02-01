// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;
using day6;
using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("Hello, World!");

//Product[] prod = new Product[]
//{
//    new Product(){Pid = 1,Pname ="apple", Pprice= 0.9f , Pcategory="fruit" },
//    new Product(){Pid = 2,Pname ="potato", Pprice= 5.3f , Pcategory="vegetable" },
//    new Product(){Pid = 3,Pname ="mangoshake", Pprice=3.2f  , Pcategory="drink" },
//    new Product(){Pid = 4,Pname ="top", Pprice=7.1f  , Pcategory="clothes" },
//    new Product(){Pid = 5,Pname ="burger", Pprice=1.0f  , Pcategory="snack" },
//    new Product(){Pid = 6,Pname ="coffee", Pprice=6.5f  , Pcategory="beverages" },
//    new Product(){Pid = 7,Pname ="banana", Pprice= 1.5f , Pcategory="fruit" },
//    new Product(){Pid = 8,Pname ="jeans", Pprice= 5f , Pcategory="clothes" },
//};

//Productrepository pr = new Productrepository(prod);
//pr.DisplayAllProducts();
//pr.DisplayProductByPrice(1.5f);
//pr.DisplayProductsByCategory("clothes");

//Console.WriteLine("_____HASH TABLE PROGRAM________");
//Hashtab hashtab = new Hashtab();
//hashtab.Addtohash();
//hashtab.CheckHash();    
//hashtab.GetCollection();

//Console.WriteLine("_____STACK PROGRAM________");
//Stck sc = new Stck();
//sc.pushtostck();
//sc.popstck();
//sc.peekstck();

//Console.WriteLine("_____QUEUE PROGRAM________");
//Que q = new Que();
//q.enqtoq();
//q.deqtoq();

Console.WriteLine("_____ GENERIC STACK PROGRAM________");
Generic_Stack sc = new Generic_Stack();
sc.pushtostck();
sc.popstck();
sc.peekstck();


Console.WriteLine("_____ GENERIC HASH TABLE PROGRAM________");
Generic_hashtable hashtab = new Generic_hashtable();
hashtab.Addtohash();
hashtab.CheckHash();    
hashtab.GetCollection();

Console.WriteLine("_____ GENERIC QUEUE PROGRAM________");
Generic_queue q = new Generic_queue();
q.enqtoq();
q.deqtoq();

Console.WriteLine("_____ GENERIC PROGRAM________");
Demo<int> obj = new Demo<int>(10, 20);
obj.Display();
Demo<char> obj2 = new Demo<char>('a', 'b');
obj.Display();
Demo<string> obj3 = new Demo<string>("hello", "World");
obj.Display();

Console.WriteLine("_____ GENERIC SWAPPING PROGRAM________");
Genericswap gs = new Genericswap();
gs.Swap<int>(10, 20);
Genericswap gs2 = new Genericswap();
gs2.Swap<char>('A', 'L');
Genericswap gs3 = new Genericswap();
gs3.Swap<string>("SWAP", "GENERIC");

