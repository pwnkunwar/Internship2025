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

            // usage of Average method 


            var scores = new[] { 2, 4, 6, 8, 10 };
            var average = scores.Average();
            Console.WriteLine($"Average number of scores is : {average}");

            // usage of Count 

            var scores1 = new[] {2,4,6,8,10};
            var scoreCount = scores1.Count();
            Console.WriteLine($"Score Count is {scoreCount}");

            // usage of Conact method

            var set1 = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var set2 = new[] { 2, 4, 6, 8, 10 };

            var result = set1.Concat(set2);
            Console.WriteLine("Conact set is:");
            foreach(var n in result)
            {
                Console.WriteLine(n);
            }

            // FIrst method usage
            var numbs = new[] { 2, 4, 6, 8, 10 };
            int first = numbs.First();
            Console.WriteLine($"First numner is{first}");


            //usage of Skip method
            var scores10 = new[] { 87,56,33,20,11};
            var newScores = scores10.Skip(3);
            Console.WriteLine("List after Skip");
            foreach(var skip in newScores)
            {
                Console.WriteLine(skip);
            }

            // Orderby method
            var cities = new[] { "Barcelona","London","Paris","New York"};
            var orderedCites = from city in cities
                               orderby city
                               select city;
            Console.WriteLine("Cities order by ascending order by default");
            foreach (var c in orderedCites)
            {
                Console.WriteLine(c);   
            }

            var desOrderedCities = orderedCites.OrderByDescending(d => d);
            Console.WriteLine("Cities order by descending order");
            foreach (var c in desOrderedCities)
            {
                Console.WriteLine(c);
            }

            // Reverse method usage
            var reverse = cities.Reverse();
            Console.WriteLine("List in Reverse order");
            foreach (var r in reverse)
            {
                Console.WriteLine(r);
            }

            // Contains method usage
            var colors = new[] { "red","blue","green","yellow","purple","orange"};
            bool result1 = colors.Contains("blue");
            Console.WriteLine(result1);
        }

    }
}
