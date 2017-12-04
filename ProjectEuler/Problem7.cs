using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem7
    {
        public void Run()
        {
            var primeCount = 0;
            var counter = 1;
            while (true)
            {
                counter++;
                if (Helper.IsPrime(counter))
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
    }
}
