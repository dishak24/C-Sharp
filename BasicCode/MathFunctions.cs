using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace BasicOnDataTypes
{
    internal class MathFunctions
    {
        public static void applyMathFunctions()
        {
            Console.WriteLine("Enter any number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("Pow = " + Math.Pow(num, 2));
            Console.WriteLine("Abs = " + Math.Abs(num));
            Console.WriteLine("round = "+Math.Round(12.6));
            Console.WriteLine("Floor = "+Math.Floor(12.6));
            Console.WriteLine("Min = " +Math.Min(100,45));
            Console.WriteLine("Max = " + Math.Max(100, 45));
            Console.WriteLine("sqrt = " + Math.Sqrt(num));



        }
    }
}
