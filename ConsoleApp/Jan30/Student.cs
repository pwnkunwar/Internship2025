using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Jan30;

    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }
    public Student(string name, int age, string course)
    {
        Name = name;
        Age = age;
        Course = course;
    }
    public void PrintDetails()
    {
      Console.WriteLine($"Student name is {Name}, age is {Age}, and Course is {Course}");
    }
}




