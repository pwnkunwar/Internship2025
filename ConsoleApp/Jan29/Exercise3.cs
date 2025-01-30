using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Jan29
{
    public static class Exercise3
    {
        public static void Duplicate()
        {
            List<string> duplicate = new List<string>();
            List<string> names = new List<string> { "Bikram", "Duwal", "Bikram", "Beek", "Duwal" };
            for (int i = 0; i < names.Count; i++)
            {
                for(int j = i+1; j < names.Count; j++)
                {
                    if (names[i] == names[j])
                    {
                        duplicate.Add(names[i]);
                    }
                }
            }
            Console.WriteLine($"Duplicate Elemets: {string.Join(", ", duplicate)}");


        }
    }
}
