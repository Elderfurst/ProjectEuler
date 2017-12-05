using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem20
    {
        public void Run()
        {
            Console.WriteLine(Helper.Factorial(100).ToString().ToCharArray().Select(x => int.Parse(x.ToString())).Sum());
        }
    }
}
