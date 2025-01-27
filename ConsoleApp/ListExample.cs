using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public static class ListExample
    {
        public static void ListDemo()
        {
            List<string> animals = new List<string> { "Cat", "Dog", "Elephant", "Lion" };
            for (int i = 0; i < animals.Count; i++)
            {
                Console.WriteLine($"Animal at index {i}: {animals[i]}");
            }
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
        public static void Insert()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            numbers.Insert(0, 100); //inserting at index 0
            foreach (var number in numbers)
            {
                Console.WriteLine($"New Updated data {number}");
            }
        }
        public static void Remove()
        {
            List<string> animals = new List<string> { "Cat", "Dog", "Lion", "Tiger" };
            animals.Remove("Cat"); //remove by value 
            animals.RemoveAt(2);
            foreach (var animal in animals)
            {
                Console.WriteLine($"New Updated data {animal}");
            }
        }
        public static void Clear()
        {
            List<double> numbers = new List<double> { 1.0, 1.1, 9.0, 4.5 };
            numbers.Clear();
            foreach (var number in numbers)
            {
                Console.WriteLine($"New Updated data {number}");
            }
        }
        public static void ListToArray()
        {
            // list to array 
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            int[] numberArray = numbers.ToArray();
            Console.WriteLine("List to Array");
            foreach (var number in numberArray)
            {
                Console.WriteLine(number);
            }
        }
        public static void ArrayToList()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            List<int> listNumber = numbers.ToList();
            Console.WriteLine("Array to List");
            foreach (var number in listNumber)
            {
                Console.WriteLine(number);
            }
        }
        public static void LINQ()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            var oddNumbers = from number in numbers where number > 4 select number;
            Console.WriteLine("Numbers");
            foreach(var number in oddNumbers)
            {
                Console.WriteLine(number);
            }
        }

    }
}
