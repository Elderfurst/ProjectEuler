using System;

namespace ProjectEuler
{
    public class Problem14 : IRunnable
    {
        public void Run()
        {
            var maxChain = 0;
            var longestChain = 0;
            for (var i = 1; i < 1000000; i++)
            {
                long temp = i;
                var chainLength = 0;
                while (temp != 1)
                {
                    if (temp % 2 == 0)
                    {
                        temp = temp / 2;
                    }
                    else
                    {
                        temp = (3 * temp) + 1;
                    }
                    chainLength++;
                }
                if (chainLength > maxChain)
                {
                    maxChain = chainLength;
                    longestChain = i;
                }
            }
            Console.WriteLine(longestChain);
        }
    }
}
