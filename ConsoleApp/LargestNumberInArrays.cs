using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public static class LargestNumberInArrays
    {
        //Create a function that takes an array of arrays with numbers.
        //Return a new (single) array with the largest numbers of each.
        public static double[] FindLargest(double[][] values)
        {
            double[] largestArray = new double[values.Length];
            int index = 0;

            foreach (double[] array in values) 
            {
                double largest = double.MinValue; 
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] > largest)
                    {
                        largest = array[j];
                    }
                }
                largestArray[index] = largest;
                index++;
            }

            return largestArray; 
        }
    }
}
