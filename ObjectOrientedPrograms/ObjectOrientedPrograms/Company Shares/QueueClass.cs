// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QueueClass.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedPrograms.Company_Shares
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Queue class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class QueueClass<T>
    {
        /// <summary>
        /// The head
        /// </summary>
        public Node<T> head = null;

        /// <summary>
        /// Inserts the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        public void Insert(T data)
        {
            Node<T> node = new Node<T>(data);
            if (head == null)
            {
                head = node;
                node.next = null;
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }

                temp.next = node;
            }
        }

        /// <summary>
        /// Removes this instance.
        /// </summary>
        public void Remove()
        {
            if (head == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            else
            {
                head.next = head;
            }           
        }

        /// <summary>
        /// Prints this instance.
        /// </summary>
        public void Print()
        {
            Node<T> temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }

            Console.WriteLine();
        }
    }
}