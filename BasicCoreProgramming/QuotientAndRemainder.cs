using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class QuotientAndRemainder
    {
        public void Quotient()
        {
            int quotient = 0, remainder = 0;
            Console.WriteLine("Enter the values of Dividend");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the values of Divisor");
            int divisor = Convert.ToInt32(Console.ReadLine());
            quotient = dividend / divisor;
            remainder = dividend % divisor;
            Console.WriteLine("Quotient =" + quotient + "\n" + "Ramainder =" + remainder);
        }
    }
}
