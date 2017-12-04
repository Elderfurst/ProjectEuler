
using System;

namespace ProjectEuler
{
    public class Problem5
    {
        public void Run()
        {
            var divisible = false;
            var num = 19;
            while (!divisible)
            {
                num++;
                for (var i = 1; i <= 20; i++)
                {
                    if (num % i != 0)
                    {
                        break;
                    }
                    else if (i == 20 && num % i == 0)
                    {
                        divisible = true;
                    }
                }
            }
            Console.WriteLine(num);
        }
    }
}
