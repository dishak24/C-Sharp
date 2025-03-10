using System;


namespace DataStructure
{
    internal class SinglyLL
    {
        internal Node head;

        public SinglyLL()
        {
            head = null;
        }

        public void InsertAtFirst(int data)
        {
            Node newNode = new Node(data);

            if ( head == null)
            {
                head = newNode;
                return;
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }
            Console.WriteLine($"{data} added successfully !");
            Console.WriteLine();

        }

        public void InsertAtLast(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                return;
            }

            Node trav = head;
            while (trav.next != null) 
            {
                trav = trav.next; 
            }
            trav.next = newNode;
            Console.WriteLine($"{data} added successfully !");
           
        }

        public void InsertAtSepecificPosition(int data, int index)
        {
            Node newNode = new Node(data);
            
            if (index == 1)
            {
                if (head == null)
                {
                    head = newNode;
                    Console.WriteLine($"{data} added at {index} index.");
                    return;
                }
                newNode.next = head;
                head = newNode;
                Console.WriteLine($"{data} added at {index} index.");
                return;
            }

            Node prev = head;
            for (int i = 1; i < index-1; i++)
            {
                prev = prev.next;

                if(prev == null)
                {
                    return;
                }
            }
            newNode.next = prev.next;
            prev.next = newNode;
            Console.WriteLine($"{data} added at {index} index.");

        }

        public void TraverseList()//Display list
        {
            Node temp = head;
            Console.Write("Head -> ");
            while (temp != null)
            {
                Console.Write(temp.data + " -> ");
                temp = temp.next;
            }
            Console.Write("NULL");
            Console.WriteLine();
        }

        public void CountNodes()
        {
            Node temp = head;
            int count =  1;

            while(temp.next != null)
            {
                count++;
                temp = temp.next;
            }
            Console.WriteLine($"{count} No. of Nodes are in List. ");
        }

        public void FindMaxNode()
        {
            int max = head.data;
            Node temp = head;
            while (temp != null)
            {
                if (max < temp.data)
                {
                    max = temp.data;
                }
                temp = temp.next;
            }
            Console.WriteLine($"{max} is maximum node in list.");
        }

        public void FindMinNode()
        {
            int min = head.data;
            Node temp = head;
            while (temp != null)
            {
                if (min > temp.data)
                {
                    min = temp.data;
                }
                temp = temp.next;
            }
            Console.WriteLine($"{min} is minimum node in list.");
        }

        public void DeleteAtFirst()
        {
            if (head == null)
            {
                Console.WriteLine("Head is NULL, you cannot delete a Node");
                return;
            }

        }

        public static void MenuDriven()
        {
            SinglyLL singlyLL = new SinglyLL();
            while (true)
            {
                //Operations to Perform
                Console.WriteLine("0. Exit ");
                Console.WriteLine("1. Add data at First ");
                Console.WriteLine("2. Add data at specific position ");
                Console.WriteLine("3. Add data at last ");
                Console.WriteLine("4. Display Linked List ");
                Console.WriteLine("5. Display no. of Count of Nodes in List ");
                Console.WriteLine("6. Find Min ");
                Console.WriteLine("7. Find Max ");
                Console.WriteLine("8. Reverse List ");
                Console.WriteLine("9. Delete First Node ");
                Console.WriteLine("10. Delete Last Node ");
                Console.WriteLine("11. Delete by value ");
                Console.WriteLine("12. Delete by position ");
                Console.WriteLine();

                Console.WriteLine("Enter your Choice :");
          

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 0:
                        Environment.Exit(0);
                        break;

                    case 1:
                        Console.WriteLine("Enter Data :");
                        singlyLL.InsertAtFirst(Convert.ToInt32(Console.ReadLine()));
                        break;

                    case 2:
                        Console.WriteLine("Enter data & Position where you want to Insert:");
                        singlyLL.InsertAtSepecificPosition(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                        break;

                    case 3:
                        Console.WriteLine("Enter Data :");
                        singlyLL.InsertAtLast(Convert.ToInt32(Console.ReadLine()));
                        break;

                    case 4:
                        singlyLL.TraverseList();
                        break;

                    default:
                        Console.WriteLine("Enter valid choice !!!!");
                        break;
                }
            }
        }
    }
}
