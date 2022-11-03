using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class SwapTwoNumber
    {
        public void SwapNumber()
        {
            Console.WriteLine("Enter Two Numbers");
            Console.WriteLine("First number is - ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second number is - ");
            int b = Convert.ToInt32(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("After Swapping First Number will be - " + a + "\n" + "After Swapping Second Number will be - " + b);
        }
    }
}