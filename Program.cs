using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimeChecker.Logic;
using PrimeChecker.Helper;

namespace PrimeChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run)
            {
                Console.WriteLine("Enter a number to check if it's prime (or 'exit' to quit):");
                string input = Console.ReadLine();
                if (!Validation.IsValid(input, out int? num, out bool isexit))
                {
                    if (isexit)
                    {
                        Console.WriteLine("Exiting program. Goodbye!");
                        break;
                    }
                    continue;
                }
                int number = (int)num;
                bool isprime = PChecker.IsPrime(number);
                Console.WriteLine($"{number} is {(isprime ? "a prime number" : "not a prime number")}.");
            }
        }
    }
}
