using System;
using System.Numerics;

namespace ProjectEuler
{
    public class Problem15
    {
        public void Run()
        {
            //Find all combinations of down and right that are possible 40 total moves to get from top left to bottom right, 20 downs, 20 rights
            //Formula = (Total possible moves)! / (Total possible moves - first option)! * (first option)!
            var fortyFactorial = Factorial(40);
            var twentyFactorial = Factorial(20);
            var answer = fortyFactorial / (twentyFactorial * twentyFactorial);
            Console.WriteLine(answer);
        }

        private static BigInteger Factorial(long number)
        {
            if (number > 1)
            {
                return number * Factorial(number - 1);
            }
            return 1;
        }
    }
}
