using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCode
{
    internal class RandomCode
    {
        public static void randomValues()
        {
            Random r = new Random();
            Console.WriteLine( r.ToString());
            Console.WriteLine("next() = " + r.Next());
            Console.WriteLine("next(100, 200) = " + r.Next(100, 200));
            Console.WriteLine("NextDouble() = " + r.NextDouble());
            Console.WriteLine();

        }
    }
}
