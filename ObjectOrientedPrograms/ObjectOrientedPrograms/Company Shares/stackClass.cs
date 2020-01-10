// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StackClass.cs" company="Bridgelabz">
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
    /// Stack class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class StackClass<T>
    {
        /// <summary>
        /// The head
        /// </summary>
        public Node<T> head = null;

        /// <summary>
        /// Pushes the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        public void Push(T data)
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
        /// Pops this instance.
        /// </summary>
        public void Pop()
        {
            Node<T> temp = head;
            Node<T> prev = null;
            if (temp == null)
            {
                Console.WriteLine("stack is empty");
            }

            while (temp.next != null)
            {
                prev = temp;
                temp = temp.next;
            }

            prev.next = null;
        }

        /// <summary>
        /// Prints this instance.
        /// </summary>
        public void Print()
        {
            Node<T> temp = head;

            if (temp == null)
            {
                Console.WriteLine("stack is empty");
            }

            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }

            Console.WriteLine();
        }
    }
}
