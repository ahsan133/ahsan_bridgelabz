// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LinkedListClass.cs" company="Bridgelabz">
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
    /// Linked list class
    /// </summary>
    /// <typeparam name="T">Any datatype.</typeparam>
    public class LinkedListClass<T>
    {
        public Node<T> head = null;
        public int count = 0;

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
        /// Determines whether this instance is empty.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is empty; otherwise, <c>false</c>.
        /// </returns>
        public bool IsEmpty()
        {
            if (head == null)
            {
                return true;
            }
            else
            {
                return false;
            }               
        }

        /// <summary>
        /// Sizes this instance.
        /// </summary>
        /// <returns>
        /// Returns the integer value of size of the linkedlist
        /// </returns>
        public int Size()
        {
            Node<T> temp = head;
            count = 0;
            if (head == null)
            {
                Console.WriteLine("the list is empty");
            }
               
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }

            return count;
        }

        /// <summary>
        /// Searches the specified word.
        /// </summary>
        /// <param name="word">The word.</param>
        /// <returns>
        /// Returns the boolean value if the value is found or not
        /// </returns>
        public bool Search(T word)
        {
            Node<T> node = new Node<T>(word);
            Node<T> temp = head;
            count = 0;
            while (temp != null)
            {
                if (Equals(temp.data, word))
                {
                    return true;
                }                  
                else
                {
                    temp = temp.next;
                }                  
            }

            return false;
        }

        /// <summary>
        /// Gets the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>
        /// returns the value of the perticular index
        /// </returns>
        public T Get(int index)
        {
            count = 0;
            Node<T> temp = head;
            while (count != index)
            {
                temp = temp.next;
                count++;
            }

            return temp.data;
        }

        /// <summary>
        /// Inserts the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <param name="data">The data.</param>
        public void Insert(int index, T data)
        {
            Node<T> node = new Node<T>(data);
            Node<T> temp = head;
            Node<T> prev = null;
            if (index == 0 && temp != null)
            {
                head = node;
                node.next = head;
                return;
            }

            while (count != index && temp != null)
            {
                prev = temp;
                temp = temp.next;
                count++;
            }

            prev.next = node;
            node.next = temp;
            return;
        }

        /// <summary>
        /// Removes the specified word.
        /// </summary>
        /// <param name="word">The word.</param>
        public void Remove(T word)
        {
            Node<T> temp = head;
            Node<T> prev = null;
            if (temp != null && Equals(temp.data, word))
            {
                head = temp.next;
                return;
            }

            while (temp != null && !Equals(temp.data, word))
            {
                prev = temp;
                temp = temp.next;
            }

            prev.next = temp.next;
            return;
        }

        /// <summary>
        /// Compares the specified x.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns></returns>
        public int Compare(T x, T y)
        {
            int a = Convert.ToInt32(x);
            int b = Convert.ToInt32(y);
            return a - b;
        }

        /// <summary>
        /// Inserts the ascending.
        /// </summary>
        /// <param name="data">The data.</param>
        public void InsertAscending(T data)
        {
            Node<T> node = new Node<T>(data);
            if (head == null)
            {
                head = node;
                node.next = null;
                return;
            }

            Node<T> temp = head;
            Node<T> prev = null;
            if (temp.next == null)
            {
                if (Compare(data, temp.data) > 0 || Compare(data, temp.data) == 0)
                {
                    temp.next = node;
                }                   
                else
                {
                    head = node;
                    head.next = temp;
                }

                return;
            }

            if (Compare(data, temp.data) < 0)
            {
                head = node;
                head.next = temp;
                return;
            }

            while (temp.next != null)
            {
                prev = temp;
                temp = temp.next;
                if (Compare(temp.data, data) > 0 || Compare(temp.data, data) == 0)
                {
                    prev.next = node;
                    node.next = temp;
                    return;
                }
            }

            temp.next = node;
            return;
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
        }
    }
}
