using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Feb10
{
    public static class CountVowels
    {
        public static void VowelsCount(string input)
        {
            string vowels = "AEIOUaeiou";
            Console.WriteLine(input.Count(c=> vowels.Contains(c)));
        }
    }
}
