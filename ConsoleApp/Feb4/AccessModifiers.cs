using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Feb4
{
    public class Car
    {
        private string engineNumber = "ABC5"; // only accessbile within the Car class
        public void ShowDetails()
        {
            Console.WriteLine($"Engine Number : {engineNumber}");
        }
    }

    public class Person
    {
        protected string Name = "VIPER"; // can be accessed by derived classes
    }
    public class  Employee : Person
    {
       public void ShowName()
        {
            Console.WriteLine($"Employee Name: {Name}");
        }
    }
}
