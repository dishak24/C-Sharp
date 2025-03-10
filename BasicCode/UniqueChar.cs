using System;
using System.Collections.Generic;
using System.Text;

namespace BasicOnDataTypes
{
    internal class UniqueChar
    {

        public static bool isUniqueChar()
        {
            Console.WriteLine("Enter the String to check unique character or not");
            String str = Console.ReadLine();

            
            char[] arr = str.ToCharArray();
            Array.Sort(arr);

            for(int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i-1])
                {
                    return false;
                }
            }
            return true;
        }

        public static void isOrNot()
        {
            if (isUniqueChar())
            {
                Console.WriteLine("Yes, All unique chars.");
            }
            else
            {
                Console.WriteLine("Not All unique chars.");
            }
        }


    }
}
