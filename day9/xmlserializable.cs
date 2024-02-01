using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace day9
{
    

    internal class Xmlserializable
    {
        public void SeriliazeProduct()
        {
            FileStream fs = new FileStream("Product.xml", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);

            XmlSerializer serialization = new XmlSerializer(typeof(Product));

            Product car = new Product("BMW", 1, 10000000);

            serialization.Serialize(fs, car);

            Console.WriteLine("Data saved in file");


        }

        public void DeserializeProduct()
        {
            FileStream fs2 = new FileStream("Product.xml", FileMode.OpenOrCreate, FileAccess.Read, FileShare.None);

            XmlSerializer serialization2 = new XmlSerializer(typeof(Product));

            Product car2 = (Product)serialization2.Deserialize(fs2);

            Console.WriteLine($"{car2.name} {car2.price} {car2.quantity}");
        }

    }

}
