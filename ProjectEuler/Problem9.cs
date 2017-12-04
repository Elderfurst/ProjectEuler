
using System;
using System.Globalization;

namespace ProjectEuler
{
    public class Problem9
    {
        public void Run()
        {
            for (var i = 1; i < 1000; i++)
            {
                for (var j = i + 1; j < 1000; j++)
                {
                    for (var k = j + 1; k < 1000; k++)
                    {
                        if (i * i + j * j == k * k && i + j + k == 1000)
                        {
                            Console.WriteLine(i * j * k);
                        }
                    }
                }
            }
        }
    }
}
