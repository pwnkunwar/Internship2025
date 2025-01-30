using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Jan29
{
    public static class Exercise5
    {
        public static void Merge()
        {
            List<int> list1 = new List<int> { 1, 2, 3 };
            List<int> list2 = new List<int> { 3,4,5 };
            List<int> mergeList = list1;

            foreach(int item in list2)
            {
                if(!list1.Contains(item))
                {
                    mergeList.Add(item);
                }
            }
            Console.WriteLine($"Merge List: {string.Join(", ", list1)}");


        }
    }
}
