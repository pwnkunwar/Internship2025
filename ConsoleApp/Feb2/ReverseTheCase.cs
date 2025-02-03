using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp.Feb2
{
    public class ReverseTheCase
    {
        public static void ReverseCase(string str)
        {
            char[] reversed = new char[str.Length];
            for(int i=0; i< str.Length; i++)
            {
                if (char.IsLower(str[i]))
                {
                    reversed[i] = char.ToUpper(str[i]);
                }
                else if(char.IsUpper(str[i]))
                {
                    reversed[i] = char.ToLower(str[i]);
                }
                else
                {
                    reversed[i] = str[i];
                }
            }
            Console.WriteLine(reversed);

        }
    }
}
