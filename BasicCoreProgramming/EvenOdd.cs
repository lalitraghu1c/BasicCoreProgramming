using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class EvenOdd
    {
        public void Even()
        {
            Console.WriteLine("Enter Value");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine(num + " is Even Number");
            else
                Console.WriteLine(num + " is Odd Number");
        }
    }
}