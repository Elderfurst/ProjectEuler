using System;
using System.Numerics;

namespace ProjectEuler
{
    public static class Helper
    {
        public static bool IsPrime(int value)
        {
            for (var i = 2; i <= Math.Sqrt(value); i++)
            {
                if (value % i == 0)
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
    }
}
