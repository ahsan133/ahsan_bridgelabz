// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LinkedListClass.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class LinkedListClass<T>
    {
        public Node<T> head = null;
        public int count = 0;
        //add a value to the list
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
        //check if the list is empty and return true or false
        public bool IsEmpty()
        {
            if (head == null)
                return true;
            else
                return false;
        }
        //return the size of the list
        public int Size()
        {
            Node<T> temp = head;
            count = 0;
            if (head == null)
                Console.WriteLine("the list is empty");
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            return count;
        }
        //search the value in the list and return true or false
        public bool Search(T word)
        {
            Node<T> node = new Node<T>(word);
            Node<T> temp = head;
            count = 0;
            while (temp != null)
            {
                if (Equals(temp.data, word))
                    return true;
                else
                    temp = temp.next;
            }
            return false;
        }
        //return the value from the index of the list
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
        //add the value to the perticular index
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
        //delete the value from the list
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
        public int Compare(T x, T y)
        {
            int a = Convert.ToInt32(x);
            int b = Convert.ToInt32(y);
            return a - b;
        }
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
                    temp.next = node;
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
        //print the list
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
