using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    public class Problem3
    {
        public void Run()
        {
            var num = 600851475143;
            var primeFactors = new List<long>();
            while (num % 2 == 0)
            {
                primeFactors.Add(2);
                num = num / 2;
            }

            for (var i = 3; i <= Math.Sqrt(num); i += 2)
            {
                while (num % i == 0)
                {
                    primeFactors.Add(i);
                    num = num / i;
                }
            }
            if (num > 2)
            {
                primeFactors.Add(num);
            }

            Console.WriteLine(primeFactors.Max());
        }
    }
}
