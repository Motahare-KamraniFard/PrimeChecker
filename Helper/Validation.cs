using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeChecker.Helper
{
    public static class Validation
    {
        public static bool IsValid(string value, out int? num, out bool isExit)
        {
            num = null;
            isExit = false;

            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("Input cannot be empty or whitespace.");
                return false;
            }

            if (value.ToLower() == "exit")
            {
                isExit = true;
                return false;
            }

            if (!int.TryParse(value, out int number))
            {
                Console.WriteLine("Input must be a valid integer.");
                return false;
            }

            if (number < 2)
            {
                Console.WriteLine("Input must be a positive integer greater than 1.");
                return false;
            }

            num = number;
            return true;
        }

    }
}

