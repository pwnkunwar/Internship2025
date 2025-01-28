using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public static class AWeekAfter
    {
        //this method add 7 days to a date and return a date
        public static string WeekAfter(string date)
        {
            DateTime dateTime = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            return dateTime.AddDays(7).ToString("dd/MM/yyyy");
        }
    }
}
