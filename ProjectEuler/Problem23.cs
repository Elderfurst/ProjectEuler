using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem23
    {
        public void Run()
        {
            var abundants = new List<int>();
            var nonAbundants = new List<int>();
            for (var i = 1; i <= 28123; i++)
            {
                if (Helper.Divisors(i).Sum() > i)
                {
                    abundants.Add(i);
                }
                var canBeMade = false;
                for (var j = 0; j < abundants.Count; j++)
                {
                    for (var k = 0; k < abundants.Count; k++)
                    {
                        if (abundants[j] + abundants[k] == i)
                        {
                            canBeMade = true;
                            break;
                        }
                    }
                    if (canBeMade)
                    {
                        break;
                    }
                }
                if (!canBeMade)
                {
                    nonAbundants.Add(i);
                }
                Console.WriteLine(i);
            }
            Console.WriteLine(nonAbundants.Sum());
        }
    }
}
