// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Node.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class Node<T>
    {
        public T data;
        public Node<T> next;

        public Node(T d)
        {
            this.data = d;
            this.next = null;
        }
    }
    public class Node1
    {
        public int data;       
        public Node1  left = null;
        public Node1 right = null;

        public Node1(int d)
        {
            this.data = d;           
        }
    }
}
