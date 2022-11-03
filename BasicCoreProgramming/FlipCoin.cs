using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class FlipCoin
    {
        Random random = new Random();
        public void Coin()
        {
            double head = 0, tail = 0;
            Console.WriteLine("\n" + "No. of Times you want to Flip the Coin");
            int times = Convert.ToInt32(Console.ReadLine());
            double actual_count = times;
            while (times > 0)
            {
                if (random.NextDouble() > 0.5)
                    head++;
                else
                    tail++;
                times--;
            }
            Console.WriteLine("Head will come - " + head);
            Console.WriteLine("Tail will come - " + tail);
            double Head_Percentage = (head / actual_count) * 100;
            double Tail_Percentage = (tail / actual_count) * 100;
            Console.WriteLine("\n" + "Head Percenage will be - " + Head_Percentage + "\n" + "Tail Percentage will be - " + Tail_Percentage);
        }
    }
}
