using System;
using System.Linq;


namespace ProjectEuler
{
    public class Problem24
    {
        public void Run()
        {
            var digits = new[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            Console.WriteLine(string.Join("", Helper.GeneratePermutations(digits.ToList())[999999]));
        }
    }
}
