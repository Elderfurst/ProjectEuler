using System;

namespace ProjectEuler
{
    public class Problem6
    {
        public void Run()
        {
            const int num = 100;
            Console.WriteLine(SquareOfSums(num) - SumOfSquares(num));
        }

        private long SumOfSquares(int maxNum)
        {
            var sumOfSquares = 0;
            for (var i = 1; i <= maxNum; i++)
            {
                sumOfSquares += (i * i);
            }
            return sumOfSquares;
        }

        private long SquareOfSums(int maxNum)
        {
            var squareOfSums = 0;
            for (var i = 1; i <= maxNum; i++)
            {
                squareOfSums += i;
            }
            return squareOfSums * squareOfSums;
        }
    }
}
