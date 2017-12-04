using System;
using System.Linq;
using System.Numerics;

namespace ProjectEuler
{
    public class Problem16
    {
        public void Run()
        {
            var result = (BigInteger) Math.Pow(2, 1000);
            //Convert the resulting number into a character array, parse each character into an int, and then add them all together
            Console.WriteLine(result.ToString().ToCharArray().Select(x => int.Parse(x.ToString())).Sum());
        }
    }
}
