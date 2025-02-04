using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Feb3
{
    public class Product
    {
        public string Name { get; set; }    
        public double Price { get; set; }
        public string Category { get; set; }


        public Product()
        {
            Name = "Iphone";
            Price = 100000.00;
            Category = "Accessories";
        }
        public Product(string name, double price, string category)
        {
            Name =name;
            Price = price;
            Category = category;
        }
        public void PrintDetails()
        {
            Console.WriteLine($"Product Name is {Name}, Price is {Price} and Category is {Category}");
        }
    }
}
