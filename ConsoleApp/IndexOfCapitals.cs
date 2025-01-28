using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp
{
    public static class IndexOfCapitals
    {
      //  Create a function that takes a single string as argument
       //     and returns an ordered array containing the indices of all capital letters in the string.
        public static int[] IndexOfCapitalsLetters(string str)
        {
            char[] characters = str.ToCharArray();
            char[] capitalLetters = new char[26];
            List<int> indexOfCapitals = new List<int>();
            for(int i = 0;  i < capitalLetters.Length; i++)
            {
                capitalLetters[i] = (char)('A' + i);
            }
            
            for(int j=0; j < characters.Length; j++)
            {
                for (int k = 0; k < capitalLetters.Length; k++)
                {
                    if (characters[j] == capitalLetters[k])
                    {
                        indexOfCapitals.Add(j);
                    }
                }
            }
            return indexOfCapitals.ToArray();

        }
    }
}
