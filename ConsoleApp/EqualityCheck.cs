using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public static class EqualityCheck
    {
        //this function take two paramter and check whethere the value and value type are equal or not
        public static bool CheckEquality(object a, object b)
        {

            if (a.GetType() == b.GetType())
            {
                if (a.Equals(b))
                {
                    return true;
                }
            }
            
            return false;
        }
    }
}
