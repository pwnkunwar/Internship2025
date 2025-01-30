using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Jan29
{
    public static class Exercise7
    {
        public static void Reverse()
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5 };
            List<int> reverse = new List<int>();
            for(int i=0; i<list.Count; i++)
            {
                reverse.Add(list[list.Count - 1-i]);
            }
            Console.WriteLine($"Reveresed List: {string.Join(", ", reverse)}");

        }
    }
}
