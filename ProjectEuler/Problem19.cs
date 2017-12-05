using System;

namespace ProjectEuler
{
    public class Problem19
    {
        public void Run()
        {
            var count = 0;
            for (var i = 1901; i < 2001; i++)
            {
                for (var j = 1; j <= 12; j++)
                {
                    DateTime dateValue = new DateTime(i, j, 1);
                    if (dateValue.ToString("dddd") == "Sunday")
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
