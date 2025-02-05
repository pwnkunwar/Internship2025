using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Feb4
{
    public class BaseClass1
    {
        private protected int secretNumber = 42;
        public void ShowSecret()
        {
            Console.WriteLine($"Secret number: {secretNumber}");
        }
    }
    public class DerivedClass1 : BaseClass1
    {
        public void DisplaySecret()
        {
            Console.WriteLine($"Accessing private protected: {secretNumber}");
        }
    }
}
