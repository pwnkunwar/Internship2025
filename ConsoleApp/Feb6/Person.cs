using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Feb6
{
    public class Person1
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public virtual void Info()
        {
            Console.WriteLine("This is Person class Info method");
        }
    }
    public class Employee1 : Person1
    {
        public void Salary()
        {
            Console.WriteLine("Employee Salary");
        }
        public override void Info()
        {
            Console.WriteLine("This is Employee1 class Info method");

        }
    }
    public class Manage : Employee1
    {
        public void Bonus()
        {
            Console.WriteLine("Bonus Manage");
        }
        public override void Info()
        {
            Console.WriteLine("This is Manage class Info method");

        }
    }
}
