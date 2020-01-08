// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LinkedListClass.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedPrograms.Company_Shares
{  
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Linked list class
    /// </summary>
    /// <typeparam name="T">Any datatype.</typeparam>
    public class LinkedListClass<T>
    {
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
        /// Removes the specified word.
        /// </summary>
        /// <param name="word">The word.</param>
        public void Remove(int i)
        {
            int count = 0;
            Node<T> temp = head;
            Node<T> prev = null;
            if (temp != null && i == 0)
            {
                head = temp.next;
                return;
            }

            while (temp != null && count != i)
            {
                count++;
                prev = temp;
                temp = temp.next;
            } 

            prev.next = temp.next;
            return;
        }

        /// <summary>
        /// Prints this instance.
        /// </summary>
        public void Print()
        {
            string json = Utility.Readjson();
            var array = JsonConvert.DeserializeObject<List<Share>>(json);
            
            Node<T> temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + "\n");
                temp = temp.next;
            }
        }

        /// <summary>
        /// Gets the count.
        /// </summary>
        /// <returns>
        /// returns the count
        /// </returns>
        public int GetCount()
        {
            int count = 0;
            Node<T> temp = head;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }

            return count;
        }

        /// <summary>
        /// Gets at.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>
        /// Returns the value at that index
        /// </returns>
        public T GetAt(int index)
        {
            int count = 0;
            Node<T> temp = head;
            while (temp != null && count != index)
            {
                count++;
                temp = temp.next;
            }

            return temp.data;
        }
    }
}