using System;
using System.Collections.Generic;
using System.Text;

namespace BasicOnDataTypes
{
    internal class PrimeNumbers
    {
       public static void primeNumPrinting()
        {
            Console.WriteLine("Enter the number to print prime numbers till that number");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Prime numbers are:");
            for (int i = 2; i <= num; i++ )
            {
                int check = 0;

                for (int j = 1; j<=i; j++)
                {
                    if( i % j == 0)
                    {
                        check++;
                    }
                }
               
                if (check == 2)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
