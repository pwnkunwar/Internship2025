using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Feb2
{
    public static class SortDescending
    {
        public static int SortDescendingNumber(int num)
        {
            char[] chars = num.ToString().ToCharArray();
            char[] descendingOrder = new char[chars.Length];
            for(int i=0; i<chars.Length; i++)
            {
                descendingOrder[i] = chars[chars.Length -1- i];
            }
            return int.Parse(new string(descendingOrder));
        }
    }
}
