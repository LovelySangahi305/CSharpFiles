using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6
{
    internal class Hashtab
    {
        Hashtable ht = new Hashtable();

        public void Addtohash() {
            
            ht.Add("001", "Zara Ali");
            ht.Add("002", "Abida Rehman");
            ht.Add("003", "Joe Holzner");
            ht.Add("004", "Mausam Benazir Nur");
            ht.Add("005", "M. Amlan");
            ht.Add("006", "M. Arif");
            ht.Add("007", "Ritesh Saikia");
        
    }
        public void CheckHash()
        {
            if (ht.ContainsValue("Nuha Ali")) {
                Console.WriteLine("This student name is already in the list");
            }
            else {
                ht.Add("008", "Nuha Ali");
            }
        }

        public void GetCollection()
        {
            // Get a collection of the keys.
            ICollection key = ht.Keys;

            foreach (string k in key)
            {
                Console.WriteLine(k + ": " + ht[k]);
            }
            Console.ReadKey();
        }
    }
    }
