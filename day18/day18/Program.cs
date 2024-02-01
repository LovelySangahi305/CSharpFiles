// See https://aka.ms/new-console-template for more information
using day18;
//Console.WriteLine("IENUMERABLE INTERFACE ");

//MyCollection myCollection = new MyCollection();
//// Use foreach to iterate over the collection
//foreach (int number in myCollection)
//{
//    Console.WriteLine(number);
//}
Console.WriteLine("ASYNCHRONOUS THREAD 1 PROGRAM ");
 
        Console.WriteLine("Start of Main");

        // Asynchronous method call
        await GetDataAsynchronously();

        Console.WriteLine("End of Main");

    static async Task GetDataAsynchronously()
    {
        Console.WriteLine("Start of GetDataAsynchronously");

        // Simulate an asynchronous operation
        await Task.Delay(3000);

        Console.WriteLine("End of GetDataAsynchronously");

    }


Console.WriteLine("THREAD 2 PROGRAM ");
    Console.WriteLine("Start of Main");

    // Synchronous method call
    GetDataSynchronously();

    Console.WriteLine("End of Main");


static void GetDataSynchronously()
{
    Console.WriteLine("Start of GetDataSynchronously");

    // Simulate a time-consuming operation
    System.Threading.Thread.Sleep(3000);

    Console.WriteLine("End of GetDataSynchronously");
}
//Indexr i = new Indexr();
//i[0] = "Samatha";  // set the value
//i[1] = "ABC";
//i[2] = "EFG";
//i[3] = "XYZ";
//i[4] = "LMN";
//i[5] = "PQR";
//i[6] = "QRS";
//i[7] = "CVB";
//i[8] = "ASD";
//i[9] = "poiu";

//for (int j = 0; j < 10; j++)
//{
//    Console.WriteLine($"i[{j}] = {i[j]}");  //get the value 
//}
