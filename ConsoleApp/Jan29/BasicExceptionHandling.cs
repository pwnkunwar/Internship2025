using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Jan29
{
    public static class BasicExceptionHandling
    {
        public static void Exception()
        {
            try
            {
                int number1 = 10, number2 = 0;
                int result = number1 / number2;
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Exception caught: " +ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block executed");
            }
        }
    }
}
