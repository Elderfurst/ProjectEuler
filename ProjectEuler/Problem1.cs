﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ProjectEuler
{
    public class Problem1 : IRunnable
    {
        public void Run()
        {
            const int max = 1000;
            var sum = 0;
            for (var i = 0; i < max; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
