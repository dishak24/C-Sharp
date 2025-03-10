using System;
using System.Reflection.Metadata;

namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Data Structure..!");

            SinglyLL.MenuDriven(); //Singly Linked List

            DictionaryClass dictionaryClass = new DictionaryClass();
            dictionaryClass.DictionaryOperation();
        }
    }
}
