using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Jan29
{
    public static class Exercise2
    {
        public static void FrequencyELement()
        {
            int[] numbers = { 1, 2, 2, 3, 3, 3 };
            Dictionary<int, int> frequency = new Dictionary<int, int>();
            foreach (int number in numbers)
            {
                if(frequency.ContainsKey(number))
                {
                    frequency[number]++;
                }
                else
                {
                    frequency[number] = 1;
                }

            }
            Console.WriteLine("Element Frequencies:");
            foreach (var item in frequency)
            {
                Console.WriteLine($"Element {item.Key}: {item.Value} times");
            }
        }
    }
}
