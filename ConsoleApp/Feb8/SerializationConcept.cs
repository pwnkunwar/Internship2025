using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp.Feb8
{
    public class Product88
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        public void JsonSerialization()
        {
            Product88 product88 = new Product88
            {
                Name = "Laptop",
                Price = 1200.50,
                Stock = 25
            };
            // Serialize the object to JSON string 
            string jsonString = JsonSerializer.Serialize(product88);
            Console.WriteLine("Serialized JSON: ");
            Console.WriteLine(jsonString);
        }
    }
}
