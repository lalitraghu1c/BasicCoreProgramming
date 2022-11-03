using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class VowelsAndConsonant
    {
        public void Vowel()
        {
            Console.WriteLine("Enter Alphabet -");
            char check = Convert.ToChar(Console.ReadLine().ToLower());
            switch (check)
            {
                case 'a':
                    Console.WriteLine(check + " is Vowel");
                    break;
                case 'e':
                    Console.WriteLine(check + " is Vowel");
                    break;
                case 'i':
                    Console.WriteLine(check + " is Vowel");
                    break;
                case 'o':
                    Console.WriteLine(check + " is Vowel");
                    break;
                case 'u':
                    Console.WriteLine(check + " is Vowel");
                    break;
                default:
                    Console.WriteLine(check + " is Consonant");
                    break;
            }
        }
    }
}