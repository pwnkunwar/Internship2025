using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp.Feb8
{
    public class Product8
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public void JsonDeserialization()
        {
            string jsonString = "{\"Name\":\"Laptop\", \"Price\":1200.50}";
            Product8 product= JsonSerializer.Deserialize<Product8>(jsonString);
            Console.WriteLine($"Product Name:{product.Name}, Price: {product.Price}");
        }
    }
}
