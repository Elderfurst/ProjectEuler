using System;

namespace ProjectEuler
{
    public class Problem1
    {
        public void Run()
        {
            const int max = 1000;
            var sum = 0;
            for (var i = 0; i < max; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
