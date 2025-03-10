using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collection
{
    internal class ListDemo
    {
        List<int> list = new List<int>();
        public void AddElement()
        {
            Console.WriteLine("Enter Element to add in list: ");
            int ele = Convert.ToInt32(Console.ReadLine());
            list.Add(ele);
            Console.WriteLine($"{ele} is added.");

        }

        public void RemoveElement()
        {
            Console.WriteLine("Enter Element to remove from list: ");
            int ele = Convert.ToInt32(Console.ReadLine());
            list.Remove(ele);
            Console.WriteLine($"{ele} is deleted.");
        }

        public void DisplayList()
        {
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public void ClearList()
        {
            list.Clear();
            Console.WriteLine("All elements in list are cleared now !!");
        }

        public void SortList()
        {
            list.Sort();
            Console.WriteLine("Sorted List: ");
            DisplayList();
        }

        public void ReverseList()
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                Console.Write(list[i] + " ");
            }
        }


        public static void ListOperations()
        {
            Console.WriteLine(" * List Collection * ");
            ListDemo listDemo = new ListDemo();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Remove");
                Console.WriteLine("3. Clear");
                Console.WriteLine("4. Display List");
                Console.WriteLine("5. Sort List");
                Console.WriteLine("6. Reversed List");
                Console.WriteLine();
                Console.WriteLine("Enter any choice:");

                switch( Convert.ToInt32(Console.ReadLine()))
                {
                    case 0:
                        Environment.Exit(0); 
                        break;

                    case 1:
                        listDemo.AddElement();
                        break;

                    case 2:
                        listDemo.RemoveElement();
                        break;

                    case 3:
                        listDemo.ClearList();
                        break;

                    case 4:
                        listDemo.DisplayList();
                        break;

                    case 5:
                        listDemo.SortList();
                        break;

                    case 6:
                        listDemo.ReverseList();
                        break;

                    default:
                        Console.WriteLine("Invalid Choice !!!!!! ");
                        break;
                }
            }

        }

    }
}
