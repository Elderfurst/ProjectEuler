using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
