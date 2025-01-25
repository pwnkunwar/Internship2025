using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public static class ReverseAndNot
    {
        public static string Reverse(int i)
        {
            //Write a function that takes an integer i and returns a string
            //with the integer backwards followed by the original integer.
            char[] chars = i.ToString().ToCharArray();
            char[] reverse = new char[chars.Length];
            int index = chars.Length;
            for(int j = 0; j < chars.Length; j++)
            {
                reverse[j] = chars[index -1];
                index--;
            }
            string reverseAndNot = new string(reverse) + i.ToString();
            return reverseAndNot;
        }
    }
}
