using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class CustomLinkedList
    {
       
            public Node head;
            //Method to Add Node in Linked List
            public void AddNode(int data)
            {
                Node newnode = new Node(data);
                //condition to Check head and add first Node.
                if (this.head == null)
                {
                    this.head = newnode;
                }
                else
                {
                    var lastNode = GetLastNode();
                    lastNode.next = newnode;
                }
                Console.WriteLine("inserted into node: " + newnode.data);
            }

            public Node GetLastNode()
            {
                //Temp Node to reference to iterate through nodes & not lose or break node
                Node temp = head;
                //Loop to check next address in Node.
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                return temp;
            }
        
    }
}
