using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Jan30
{
    //base class
    public class Person
    {
        public string Name { get; set; }    
        public void ShowName()
        {
            Console.WriteLine($"Name:{Name}");
        }
    }

    //Derived Class
    public class Employee : Person
    {
        public double Salary { get; set; }
        public void ShowSalary()
        {
            Console.WriteLine($"{Name} Salary : {Salary}");
        }
    }

    public class Manager : Employee
    {
        public string Department { get; set; }
        public void ShowDepartment()
        {
            Console.WriteLine($"{Name} manges the {Department} department");
        }

    }
}
