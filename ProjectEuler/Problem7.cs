using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem7 : IRunnable
    {
        public void Run()
        {
            var primeCount = 0;
            var counter = 1;
            while (true)
            {
                counter++;
                if (IsPrime(counter))
                {
                    primeCount++;
                    if (primeCount == 10001)
                    {
                        Console.WriteLine(counter);
                        return;
                    }
                }
            }
        }

        private static bool IsPrime(int value)
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
