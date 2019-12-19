using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Utility
    {
        Node head = null;
        public class Node
        {
            int data;
            public Node next = null;
            public Node(int data)
            { 
                this.data = data;
                this.next = null;
            }
        }
        public void Insert(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
                node.next = null;
            }
            else
            {
                Node last = head;
                node.next = node;
            }
        }
        public void Print()
        {
            Node temp = head;
            while(temp.next!=null)
            {
                Console.WriteLine(temp);
                temp = temp.next;
            }
        }
    }
}
