using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class Node
    {
        //Instance var.
        public int data;
        public Node next;
        //Constructor to create a Node with data and next pointer.
        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
    public class SortedNode<T>
    {
        public T data;
        public SortedNode<T> next;
       
        public SortedNode(T data)
        {
            this.data = data;
            this.next = null;
        }
    }
}

