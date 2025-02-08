using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Feb7
{
    // calling base class constructor
    public class Animal2
    {
        public string Name;

        public Animal2(string name)
        {
            Name = name;
            Console.WriteLine($"Animal constructor called");
        }
    }
    public class Dog2 : Animal2
    {
        public Dog2(string name): base(name)
        {
            Console.WriteLine($"Dog constructor called");
        }
    }
}
