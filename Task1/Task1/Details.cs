using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class Details
    {
        public static void UserDetails()
        {
            Console.Write("Enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter your address: ");
            string address = Console.ReadLine();

            Console.WriteLine("--- User Information ---");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Address: {address}");
        }
    }
}
