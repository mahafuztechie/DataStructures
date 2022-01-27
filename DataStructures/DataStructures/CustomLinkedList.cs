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
            public void AddLast(int data)
            {
                Node newnode = new Node(data);
                //condition to Check head and add first Node.
                if (this.head == null)
                {
                    this.head = newnode;
                }
                else
                {
                    //Temp Node to reference to iterate through nodes & not lose or break node
                    Node temp = head;
                    //Loop to check next address in Node.
                    while (temp.next != null)
                    {
                        temp = temp.next;
                    }
                    temp.next = newnode;
                }
                Console.WriteLine("inserted into node: " + newnode.data);
            }

            //Display Method
            public void DisplayLinkedList()
            {
                Console.WriteLine("Display nodes of Linked List");
                Node temp = head;
                if (temp == null)
                {
                    Console.WriteLine("Linked list is Empty");
                    return;
                }
                else
                {
                    while (temp != null)
                    {
                        Console.WriteLine("Nodes are : " + temp.data);
                        temp = temp.next;
                    }
                }
            }
            //Method to Add Node at First in Linked List
            public void AddFirst(int data)
            {
                Node newnode = new Node(data);
                newnode.next = head;
                head = newnode;
                Console.WriteLine("{0} : Nodes inserted in Linked list ", newnode.data);
            }

            //method to append 
            public void Append(int data)
            {
                AddLast(data);
                Console.WriteLine("{0} node Appended", data);
            }

        //method to insert at certain position
            public void InsertAtPosition(int pos, int data)
            {
            Node temp;
            int i;
            //if position is 1 then insert at start
            if(pos==1)
            {
                 temp = new Node(data);
                 temp.next = head;
                 head = temp;
                 return;
            }
            Node p = head;
            //position may be more than available nodes so loop to traverse on condition if p is null then terminate loop
            for(i =1; i<pos-1 && p!=null; i++)
            {
                p = p.next;

            }
            //if p is null prompt msg to user
            if(p == null)
            {
                Console.WriteLine("you can insert only upto " +i+ "th position");
            }
            //if p is not null then create new node  & pass the data & p pointer to temp pointer & temp to p pointer
            else
            {
                temp = new Node(data);
                temp.next = p.next;
                p.next = temp;
                Console.WriteLine("node inserted at position : " + (i+1));

            }
            }
        public int DeleteFirst()
            {
                if (this.head == null)
                {
                    Console.WriteLine("list is already empty, there is nothing to delete");
                return 0;
                }
                int deleteNode = this.head.data;
                this.head = this.head.next;
                Console.WriteLine("node deleted is " +deleteNode);
                return deleteNode;
            }

            //Method to delete Last Node
            public int DeleteLast()
            {
                Node newNode = this.head;
                if (this.head == null)
                {
                Console.WriteLine("list is already empty, there is nothing to delete");
                return 0;
                }
                if (this.head.next == null)
                {
                    this.head = null;
                    return 0;
                }
                //checking for tail Node.
                while (newNode.next.next != null)
                {
                    newNode = newNode.next;
                }
                int deleteLastNode = newNode.next.data;
                newNode.next = null;
                Console.WriteLine("node deleted at Last position is " + deleteLastNode);
                return deleteLastNode;
            }

            public int SearchNode(int value)
            {
                Node temp = this.head;
                while (temp != null)
                {
                    if (temp.data == value)
                    {
                    Console.WriteLine("the node is found : " +value);
                        return value;
                    }
                    temp = temp.next;
                }
                Console.WriteLine("{0} is not a Linked List Node", value);
                return 0;
            }

        //method to insert value after a certain value
            public void InsertAfter(int data, int x)
            {
            Node p = head;
            while(p!=null)
            {
                if(p.data==x)
                {
                    break;
                   
                }
                p = p.next;
            }
            if(p==null)
            {
                Console.WriteLine(x + "not present in list");

            }
            else
            {
                Node temp = new Node(data);
                temp.next = p.next;
                p.next = temp;
            }
            }

        //method to find the size of linked list
            public void Size()
            {
                if (this.head == null)
                {
                    Console.WriteLine("Linked list is Empty");
                    return;
                }
                int count = 0;
                Node temp = this.head;
                while (temp != null)
                {
                    temp = temp.next;
                    count++;
                }
                Console.WriteLine("Size of Linked List:" + count);
            }


    }
}
