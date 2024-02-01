using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace day9
{
    public class Product
    {
        

            [XmlElementAttribute("Name")]
            public string name;
            [XmlAttributeAttribute("Quantity")]
            public int quantity;
            [XmlAttributeAttribute("Price")]
            public int price;

            public Product()
            {
            }

            public Product(string name, int quantity, int price)
            {
                this.name = name;
                this.quantity = quantity;
                this.price = price;
            }
        }
    }

