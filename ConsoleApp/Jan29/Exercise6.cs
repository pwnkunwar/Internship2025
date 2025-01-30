using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Jan29
{
    public static class Exercise6
    {
        public static void SecondLargestElement()
        {
            int largest = int.MinValue;
            int secondLargest = int.MaxValue;
            int[] numbers = { 10, 20, 4, 45, 99 };
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > largest)
                {
                    secondLargest = largest;
                    largest = numbers[i];
                }
                else if(numbers[i] > secondLargest)
                {
                    secondLargest = numbers[i];
                }
            }
            Console.WriteLine(secondLargest);
        }
    }
}
