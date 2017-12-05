using System;

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
