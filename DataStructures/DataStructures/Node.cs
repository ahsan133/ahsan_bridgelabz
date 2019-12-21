using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class Node<T>
    {
        public T data;
        public Node<T> next = null;

        public Node(T d)
        {
            this.data = d;
            this.next = null;
        }
    }
}
