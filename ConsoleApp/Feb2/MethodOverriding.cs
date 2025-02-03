using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Feb2
{
    //method overriding
    public class Animal1 // Base class
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }
    public class Dog1 : Animal1
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }
    public class Cat1 : Animal1
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat meows");
        }
    }
}
