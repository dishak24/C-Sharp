using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    internal class DictionaryClass
    {
        Dictionary<string, Int16> dict = new Dictionary<string, Int16>();

        public void DictionaryOperation()
        {
            dict.Add("A", 10);
            dict.Add("B", 20);
            dict.Add("C", 30);
            dict.Add("D", 40);

            foreach (var i in dict) // var is container only. Cannot pass as parameter to any method.
            {
                Console.WriteLine(i.Key+ " "+i.Value);
            }

            Console.WriteLine(dict.Count);
        }

    }
}
