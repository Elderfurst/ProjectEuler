using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem22
    {
        private readonly string[] _names = File.ReadAllText(@"Input/Problem22.txt").Split(',')
            .Select(x => x.Replace("\"", "")).OrderBy(x => x).ToArray();
        public void Run()
        {
            Console.WriteLine(_names.Sum(name => name.Sum(letter => letter < 97 ? letter - 64 : letter - 96) * (Array.IndexOf(_names, name) + 1)));
        }
    }
}
