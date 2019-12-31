// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Node.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace DataStructures
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Initializing and declaring node for linked list
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Node<T>
    {
        public T data;
        public Node<T> next;

        public Node(T data)
        {
            this.data = data;
            this.next = null;
        }
    }

    /// <summary>
    /// Initializing and declaring nodes for binary tree 
    /// </summary>
    public class Node1
    {
        int data;       
        Node1 left = null;
        Node1 right = null;

        public Node1(int data)
        {
            this.data = data;           
        }
    }
}
