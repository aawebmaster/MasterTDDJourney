using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeapYear
{
    public class LeapYear
    {
        public static bool IsLeapYear(int year) 
        {
            return (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0));
        }
    }
}