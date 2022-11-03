using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgrammingProblems
{
    public class LeapYear
    {
        public void Leap()
        {
            Console.WriteLine("Enter Year - ");
            int year = Convert.ToInt32(Console.ReadLine());
            if ((year % 4 == 0 || year % 400 == 0) && year % 100 != 0)
                Console.WriteLine("Year " + year + " is a Leap Year");
            else
                Console.WriteLine("Year " + year + " is not a Leap Year" + "\n");
        }
    }
}