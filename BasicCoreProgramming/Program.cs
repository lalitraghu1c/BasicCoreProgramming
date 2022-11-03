using FunctionalProgrammingProblems;
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
                Console.WriteLine("1. Flip Coin" + "\n" + "2. Leap Year" + "\n" + "3. Power of Two" + "\n" + "4. Harmonic Number" + "\n" + "5. Prime Factor" + "\n" + "6. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        FlipCoin flip = new FlipCoin();
                        flip.Coin();
                        break;
                    case 2:
                        LeapYear leap = new LeapYear();
                        leap.Leap();
                        break;
                    case 3:
                        PowerOfTwo power = new PowerOfTwo();
                        power.Power();
                        break;
                    case 4:
                        HarmonicNumber harmonic = new HarmonicNumber();
                        harmonic.Harmonic();
                        break;
                    case 5:
                        PrimeFactor prime = new PrimeFactor();
                        prime.Prime();
                        break;
                    default:
                        flag = false;
                        Console.WriteLine("Try Again");
                        break;
                }
            }
        }
    }
}