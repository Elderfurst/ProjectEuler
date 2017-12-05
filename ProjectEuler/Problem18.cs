using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace ProjectEuler
{
    public class Problem18
    {
        public void Run()
        {
            //http://www.geeksforgeeks.org/maximum-path-sum-triangle/
            var input = File.ReadAllLines(@"Input/Problem18.txt");
            input = input.Reverse().ToArray();
            var maxLength = input[0].Split(' ').Length;
            input = input.Reverse().ToArray();
            var ints = new List<List<int>>();
            foreach (var entry in input)
            {
                var splitEntry = entry.Split(' ');
                var tempList = new List<int>();
                for (var i = 0; i < maxLength; i++)
                {
                    if (i < splitEntry.Length)
                    {
                        tempList.Add(int.Parse(splitEntry[i]));
                    }
                    else
                    {
                        tempList.Add(0);
                    }
                }
                ints.Add(tempList);
            }

            for (var i = ints[0].Count - 2; i >= 0; i--)
            {
                for (var j = 0; j <= i; j++)
                {
                    ints[i][j] = ints[i + 1][j] > ints[i + 1][j + 1] ? ints[i][j] + ints[i + 1][j] : ints[i][j] + ints[i + 1][j + 1];
                }
            }
            Console.WriteLine(ints[0][0]);
        }
    }
}
