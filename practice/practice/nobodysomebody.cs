using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    public class nobodysomebody
    {
 
            public static void Main(string[] args)
            {
                //Update the code below
                ArrayList alObj;
                alObj = new ArrayList();
                int max = 10;
                string item = "";
                for (int i = 0; i < max; i++)
                {
                    item = Console.ReadLine();
                    if (item != null)
                    {
                        if (item == "Nobody".Trim() || item == "Somebody".Trim())
                            alObj.Remove(item);
                        else
                            alObj.Add(item);
                    }
                    Console.WriteLine(item1);
                }
                alObj.Sort();
                foreach (var item1 in alObj)
                {
                    Console.WriteLine(item1);
                }



            }
        }

    }
