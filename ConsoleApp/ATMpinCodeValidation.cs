using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public static class ATMpinCodeValidation
    {

        // ATM machines allow 4 or 6 digit PIN codes and PIN codes cannot contain anything but exactly 4 digits or exactly 6 digits.
        // Your task is to create a function that takes a string and returns true if the PIN is valid and false if it's not.
        public static bool PinValidation(string pin)
        {
            if (pin.Length == 4 || pin.Length == 6)
            {
                foreach (char c in pin)
                {
                    if (char.IsDigit(c))
                    {
                        return true;
                    }
                }
            }
         
            return false;
        }
    }
}
