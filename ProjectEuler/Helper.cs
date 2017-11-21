using System;

namespace ProjectEuler
{
    public static class Helper
    {public static bool IsPrime(int value)
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
    }
}
