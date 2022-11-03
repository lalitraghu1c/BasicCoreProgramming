using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class LargestAmong3Numbers
    {
        public void Largest()
        {
            Console.WriteLine("Enter First Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third Number");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {

                if (num1 > num3)
                {
                    Console.WriteLine("largest number is : " + num1);
                }
                else
                {
                    Console.WriteLine("largest number is : " + num3);
                }
            }
            else
            {
                if (num2 > num3)
                {
                    Console.WriteLine("largest number is : " + num2);
                }
                else
                {
                    Console.WriteLine("largest number is : " + num3);
                }
            }
        }
    }
}