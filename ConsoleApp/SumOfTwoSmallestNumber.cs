using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class SumOfTwoSmallestNumber
    {
        // return sum of two small number from an array
        public static int SumSmallest(int[] values)
        {
            int smallest1 = int.MaxValue;
            int smallest2 = int.MaxValue;

            for(int i=0; i<values.Length; i++)
            {
                if(values[i] < smallest1 && values[i] > 0)
                {
                    smallest2 = smallest1;
                    smallest1 = values[i];
                }
                else if(values[i] < smallest2 && values[i] > 0)
                {
                    smallest2 = values[i];
                }
            }
            return smallest1 + smallest2;
        }
    }
}
