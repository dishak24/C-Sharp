using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicOnDataTypes
{
    internal class AnagramStr
    {
        public static void anagramString()
        {
            Console.WriteLine("Enter the 1st String to check anagram or not");
            String str1 = Console.ReadLine();
            Console.WriteLine("Enter the 2nd String to check anagram or not");
            String str2 = Console.ReadLine();

            char[] arr1 = str1.ToCharArray();
            char[] arr2 = str2.ToCharArray();

            Array.Sort(arr1);
            Array.Sort(arr2);

            if (arr1.SequenceEqual(arr2))
            {
                Console.WriteLine("Yup, the strings are Anagram !");
            }
            else
            {
                Console.WriteLine("Nahh!, the strings are not Anagram !");
            }
        }
    }
}
