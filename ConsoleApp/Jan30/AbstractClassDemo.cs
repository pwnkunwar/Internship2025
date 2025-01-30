using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Jan30
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public abstract void MakeSound();
        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }
    }
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks: Woof woof!");
        }
    }
}

