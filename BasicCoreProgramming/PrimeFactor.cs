using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class PrimeFactor
    {
        public void Prime()
        {
            Console.WriteLine("Enter your number");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i + " is a factor of " + num);
                }
            }
        }
    }
}