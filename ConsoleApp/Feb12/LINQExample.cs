using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Feb12
{
    public class LINQExample
    {
        public void LINQEx()
        {
            List<int> numbers = new List<int> { 1,2,3,4,5,6,7,8,9,10};

            //Query Syntax
            var evenNumbers = from num in numbers
                              where num % 2 ==0
                              select num;

            // Method syntax
            var evenNumbersMethod = numbers.Where(num => num % 2 == 0);
            Console.WriteLine("Even numbers {Query Synatx}");
            foreach(var num in evenNumbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Even numbers {Method Syntax}");
            foreach(var num in evenNumbersMethod)
            {
                Console.WriteLine(num);
            }
        }
    }
}
