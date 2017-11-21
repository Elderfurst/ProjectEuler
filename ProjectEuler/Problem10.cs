using System;

namespace ProjectEuler
{
    public class Problem10 : IRunnable
    {
        public void Run()
        {
            long sum = 0;
            for (var i = 2; i < 2000000; i++)
            {
                if (Helper.IsPrime(i))
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
