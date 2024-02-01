using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    internal class AutoImpcollection
    {
        public void DisplayFor()
        {
            Console.WriteLine($"_____ARRAY LIST USING FOR LOOP AND ADD METHOD_____");
            ArrayList arrayList = new ArrayList();
            arrayList.Add(27);
            arrayList.Add("HII");
            arrayList.Add('K');
            arrayList.Add(31.4f);
            arrayList.Add(true);

            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }
        }

        public void DisplayForeach()
        {
            //Autoimplemented collection
            Console.WriteLine($"_____ARRAY LIST USING FOREACH LOOP AND AUTO IMPLEMENTED COLLECTIONS_____");
            ArrayList arrayList = new ArrayList() { 1, "Hello", 'e', 23.4f, true };

            foreach (var a in arrayList)
            {
                Console.WriteLine($"{a}");
            }
        }
    }
}
