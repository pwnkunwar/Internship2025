using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Feb2
{
    public class AsynchronousProgramming
    {
        public async Task DoWorkAsync()
        {
            Console.WriteLine("Working...");
            await Task.Delay(2000); // simulates a 2 second delay
            Console.WriteLine("Work Completed");
        }
    }
}
