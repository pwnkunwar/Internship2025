using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Jan30
{
    public static class RotateAList
    {
        public static void Rotate()
        {
            List<int> RotatedList = new List<int>();
            List<int> numbers = new List<int>{ 1, 2, 3, 4, 5 };
            Console.WriteLine("Enter the rotation positions");
            int k = int.Parse(Console.ReadLine());
            for(int i=k; i< numbers.Count; i++)
            { 
                RotatedList.Add(numbers[i]);
            }
            for(int i = 0; i< k; i++)
            {
                RotatedList.Add(numbers[i]);
            }
            Console.WriteLine($"Merge List: {string.Join(", ", RotatedList)}");

        }
    }
}
