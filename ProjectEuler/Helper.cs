using System;
using System.Collections.Generic;
using System.Numerics;

namespace ProjectEuler
{
    public static class Helper
    {
        public static bool IsPrime(int number)
        {
            for (var i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static BigInteger Factorial(long number)
        {
            if (number > 1)
            {
                return number * Factorial(number - 1);
            }
            return 1;
        }

        public static int[] Divisors(int number)
        {
            var divisors = new List<int>();
            for (var i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    divisors.Add(i);
                }
            }
            return divisors.ToArray();
        }
    }
}
