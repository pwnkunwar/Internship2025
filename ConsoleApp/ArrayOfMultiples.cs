using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public static class ArrayOfMultiples
    {
        // Create a function that takes two numbers as arguments (num, length) and
        // returns an array of multiples of num until the array length reaches length. 
        public static int[] ArrayOfMultiple(int num, int length)
        {
            int[] array = new int[length];
            for(int i=1; i <= length; i++)
            {
                array[i-1] = num * i;
            }
            return array;
        }
    }
}
