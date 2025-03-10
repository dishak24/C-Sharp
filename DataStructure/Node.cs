using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    internal class Node
    {
        internal int data;
        internal Node next;

        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
}
