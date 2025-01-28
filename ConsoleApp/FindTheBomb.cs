using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class FindTheBomb
    {
        //Create a function that finds the word "bomb" in the given string (not case sensitive). If found,
        //return "Duck!!!", otherwise, return "There is no bomb, relax.".
        public static string Bomb(string txt)
        {
            if(txt.ToLower().Contains("bomb"))
            {
                return "Duck!!!";
            }
            return "There is no bomb, relax.";
        }
    }
}
