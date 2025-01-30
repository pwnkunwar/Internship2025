using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Jan29
{
    public static class Exercise8
    {
        public static bool Palindrome()
        {
            int[] numbers = { 1, 2,3, 2, 1 };
            bool counter = false;
            for(int i=0; i<numbers.Length; i++)
            {
                if(numbers[i] == numbers[numbers.Length-i -1])
                {
                    counter = true;
                }
                else
                {
                    counter = false;
                }
            }
            return counter;
        }
    }
}
