using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem2
    {
        public void Run()
        {
            var first = 1;
            var second = 2;
            var sum = 0;
            while (second <= 4000000)
            {
                if (second % 2 == 0)
                {
                    sum += second;
                }
                var temp = second;
                second = first + second;
                first = temp;
            }
            Console.WriteLine(sum);
        }
    }
}
