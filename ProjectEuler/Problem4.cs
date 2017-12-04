using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem4
    {
        public void Run()
        {
            var largestPalindrome = 0;
            for (var i = 999; i >= 100; i--)
            {
                for (var j = 999; j >= 100; j--)
                {
                    if (IsPalindrome(i * j) && i*j > largestPalindrome)
                    {
                        largestPalindrome = i * j;
                    }
                }
            }
            Console.WriteLine(largestPalindrome);
        }

        private bool IsPalindrome(int testNum)
        {
            return testNum.ToString() == new string(testNum.ToString().ToCharArray().Reverse().ToArray());
        }
    }
}
