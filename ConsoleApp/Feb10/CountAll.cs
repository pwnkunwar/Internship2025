using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Feb10
{
    public static class CountAll
    {
        public static void count_all(string input)
        {
            var result = new
            {
                LETTERS = input.Count(char.IsLetter),
                DIGITS = input.Count(char.IsDigit),
            };
            Console.WriteLine($"LETTERS = {result.LETTERS}, DIGITS = {result.DIGITS}");
        }
    }
}
