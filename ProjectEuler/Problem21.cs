using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem21
    {
        public void Run()
        {
            var sum = 0;
            var amicables = new List<int>();
            for (var i = 220; i < 10000; i++)
            {
                if (!amicables.Contains(i))
                {
                    var tempSum = Helper.Divisors(i).Sum();
                    if (Helper.Divisors(tempSum).Sum() == i && tempSum != i)
                    {
                        sum += tempSum + i;
                        amicables.Add(tempSum);
                        amicables.Add(i);
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
