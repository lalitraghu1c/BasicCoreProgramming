using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class HarmonicNumber
    {
        public double Harmonic()
        {
            double num = 0;
            Console.WriteLine("\n" + "Enter the value till you want Harmonic Number");
            double n = Convert.ToInt32(Console.ReadLine());
            for (double i = 1; i <= n; i++)
            {
                num += (double)(1 / i);
                Console.WriteLine("1/" + i);
                Console.WriteLine("\t" + num);
            }
            return num;
        }
    }
}
