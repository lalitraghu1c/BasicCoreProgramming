using System;
namespace BasicCoreProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome to Basic Core Programming Problems" + "\n" + "Enter your Choice");
                Console.WriteLine("1. Flip Coin" + "\n" + "2. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        FlipCoin flip = new FlipCoin();
                        flip.Coin();
                        break;
                    case 2:
                        flag = false;
                        Console.WriteLine("Try Again");
                        break;
                }
            }
        }
    }
}