using System;
using System.Collections.Generic;

namespace ProjectEuler
{
    public class Problem12
    {
        public void Run()
        {
            var factors = new List<int>();
            var num = 1;
            var triangleNum = 0;
            while (factors.Count <= 500)
            {
                factors.Clear();
                num++;
                triangleNum = 0;
                for (var i = 0; i < num; i++)
                {
                    triangleNum += i;
                }
                for (var i = 1; i < triangleNum; i++)
                {
                    if (triangleNum % i == 0)
                    {
                        factors.Add(i);
                    }
                }
            }
            Console.WriteLine(triangleNum);
        }
    }
}
