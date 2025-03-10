using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCode
{
    internal class DateTimeFunctions
    {
        public static void datefunction()
        {
            DateTime dt = DateTime.Now;

            Console.WriteLine(dt.Year);
            Console.WriteLine(dt.Month);
            Console.WriteLine(dt.Day);
            Console.WriteLine(dt.Hour);
            Console.WriteLine(dt.Minute);
            Console.WriteLine(dt.Second);
            Console.WriteLine(dt.Millisecond);
            Console.WriteLine(dt.DayOfWeek);
            Console.WriteLine(dt.DayOfYear);
        }
    }
}
