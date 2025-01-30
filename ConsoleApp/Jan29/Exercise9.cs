using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Jan29
{
    public static class Exercise9
    {
        public static void CommonElements()
        {
            List<int> list1 = new List<int> { 1, 2, 3, 4, 5 };
            List<int> list2 = new List<int> { 3, 4, 6, 7 };

            List<int> common = new List<int>();

            foreach(int item in list1)
            {
                if(list2.Contains(item))
                {
                    common.Add(item);
                }
            }
            Console.WriteLine($"Common Elements: {string.Join(", ", common)}");

        }
    }
}
