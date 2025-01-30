using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Jan29
{

    public static class ExceptionHandeling
    {
        public static void ExceptionWithThrow()
        {
            try
            {
               Method1();
                //Method2();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception caught in ExceptionWithThrow: "+ ex.Message);
                Console.WriteLine("StackTrace:\n"+ex.StackTrace);
            }

        }
        private static void Method1()
        {
            try
            {
                int num1 = 10, num2 = 0;
                int result = num1 / num2;
            }catch(Exception ex)
            {
                Console.WriteLine("logging:Exception is Method1");
                throw;
            }
        }
        private static void Method2()
        {
                try
                {
                    int num1 = 10, num2 = 0;
                    int result = num1 / num2;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("logging:Exception is Method2");
                    throw ex;
               }
        }
    }
}
