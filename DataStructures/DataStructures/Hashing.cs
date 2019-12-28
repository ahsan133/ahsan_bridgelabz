// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Hashing.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic; 
using System.Text;

namespace DataStructures
{
    class Hashing<T,U>
    {
        public Node<U>[] head = new Node<U>[11];
        public void Insert(T Key,U value)
        {
            int key = Convert.ToInt32(Key);
            Node<U> node = new Node<U>(value);
            if (head[key] == null)
            {
                head[key] = node;
                return;
            }
            else
            {
                Node<U> temp = head[key];
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }            
        }
        public void Remove(T Key, U value)
        {
            int key = Convert.ToInt32(Key);
            Node<U> node = new Node<U>(value);
            Node<U> temp = head[key];
            Node<U> prev = null;
            if (temp!=null && Equals(temp.data,value))
            {
                head[key] = temp.next;
                return;
            }
            if(temp != null && !Equals(temp.data, value))
            {
                prev = temp;
                temp = temp.next;
            }
            prev.next = temp.next;
        }
        public bool Search(U value)
        {
            for(int i=0;i<=10;i++)
            {
                Node<U> temp = head[i];
                while(temp!=null)
                {
                    if (Equals(temp.data, value))
                        return true;
                    temp = temp.next;
                }
            }
            return false;
        }
        public void Print()
        {
            for(int i=0;i<=10;i++)
            {
                Node<U> temp = head[i];
                Console.Write(i);
                while (temp!=null)
                {
                    Console.Write("-->"+temp.data);
                    temp = temp.next;
                }
                Console.WriteLine();
            }
        }
    }
}
