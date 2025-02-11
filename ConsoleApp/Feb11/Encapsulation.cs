using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Feb11
{
    public class Student11
    {
        private string _name;
        private int _age;
        public string Name
        {   get 
            { 
                return _name;
            }
            set
            { 
                _name = value; 
            } 
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if(value > 0 &&  value < 150)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Age must be positive number.");
                }
            }
        }
        public void PrintDetails()
        {
            Console.WriteLine($"Student Name: "+ Name);
            Console.WriteLine($"Student Age "+ Age);
        }
    }
}
