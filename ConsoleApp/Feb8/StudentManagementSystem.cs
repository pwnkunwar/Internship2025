using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Feb8
{
    public class Student10
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Grade { get; set; }
        public Student10(string name, int age, double grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Student Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Grade: {Grade}");

        }
    }
    public class GraduateStudent : Student10
    {
        public string ResearchTopic { get; set; }
        public GraduateStudent(string name, int age, double grade, string researchTopic)
            : base(name, age, grade)
        {
            ResearchTopic = researchTopic;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Research Topic {ResearchTopic}");
        }

    }
    }
