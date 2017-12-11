using System;
using System.Numerics;

namespace ProjectEuler
{
    public class Problem25
    {
        public void Run()
        {
            BigInteger first = 1;
            BigInteger second = 1;
            BigInteger counter = 2;
            while (second.ToString().Length < 1000)
            {
                var temp = second;
                second = first + second;
                first = temp;
                counter++;
            }
            Console.WriteLine(counter);
        }
    }
}
