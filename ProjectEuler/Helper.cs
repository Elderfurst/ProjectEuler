using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace ProjectEuler
{
    public static class Helper
    {
        public static bool IsPrime(int number)
        {
            for (var i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static BigInteger Factorial(long number)
        {
            if (number > 1)
            {
                return number * Factorial(number - 1);
            }
            return 1;
        }

        public static int[] Divisors(int number)
        {
            var divisors = new List<int>();
            for (var i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    divisors.Add(i);
                }
            }
            return divisors.ToArray();
        }

        public static List<List<T>> GeneratePermutations<T>(List<T> items)
        {
            var currentPermutation = new T[items.Count];

            var inSelection = new bool[items.Count];

            var results = new List<List<T>>();

            PermuteItems<T>(items, inSelection, currentPermutation, results, 0);

            return results;
        }

        private static void PermuteItems<T>(IReadOnlyList<T> items, IList<bool> inSelection, IList<T> currentPermutation, ICollection<List<T>> results, int nextPosition)
        {
            if (nextPosition == items.Count)
            {
                results.Add(currentPermutation.ToList());
            }
            else
            {
                for (var i = 0; i < items.Count; i++)
                {
                    if (!inSelection[i])
                    {
                        inSelection[i] = true;
                        currentPermutation[nextPosition] = items[i];

                        PermuteItems<T>(items, inSelection, currentPermutation, results, nextPosition + 1);

                        inSelection[i] = false;
                    }
                }
            }
        }
    }
}
