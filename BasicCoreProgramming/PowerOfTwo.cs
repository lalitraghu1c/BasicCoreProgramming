using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class PowerOfTwo
    {
        public void Power()
        {
            Console.WriteLine("\n" + "Enter the value till you want Power of Two");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= n && n < 32; i++)
            {
                double num = Math.Pow(2, i);
                Console.WriteLine("2^" + i + "=" + num);
            }
        }
    }
}