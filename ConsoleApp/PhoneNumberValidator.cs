using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public static class PhoneNumberValidator
    {
        //Create a function that accepts a string and returns true if it's in the format of a proper phone number and false if it's not.
        //Assume any number between 0-9 (in the appropriate spots) will produce a valid phone number.
        // This is what a valid phone number looks like: (123) 456-7890
        public static bool PhoneNumberValidation(string str)
        {
            string pattern = @"^\(\d{3}\) \d{3}-\d{4}$";   //\d is a shorthand for any digit (0–9).
            return Regex.IsMatch(str, pattern); 

        }
    }
}
