// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DequeClass.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class DequeClass<T>
    {
        public int front=0;
        public int rear=0;
        public T[] deq;

        public DequeClass (int size)
        {
            deq= new T[size+1];
        }
        public void AddFront(T data)
        {
            if (rear <= 0)
            {
                deq[++rear] = data;
                return;
            }
            else
            {
                for (int i = rear; i > 0; i--)
                    deq[i + 1] = deq[i];
                deq[1]= data;
                rear += 1;
            }
        }
        public void AddRear(T data)
        {
            if (rear <= 0)
            {
                deq[++rear] = data;
                return;
            }
            else
                deq[++rear] = data;
        }
        public void RemoveFront()
        {
            if(rear<=0)
            {
                Console.WriteLine("deque is empty");
                return;
            }
            else
            {
                for (int i = 1; i < rear; i++)
                {
                    deq[i] = deq[i + 1];
                }
                rear--;
            }
        }
        public void RemoveRear()
        {
            if (rear <= 0)
            {
                Console.WriteLine("deque is empty");
                return;
            }
            else
                --rear;
        }
        public T PeekRear()
        {
            return deq[rear];
        }
        public void Print()
        {
            for (int i = 1; i <= rear; i++)
                Console.Write(deq[i] + " ");
            Console.WriteLine();
        }
    }
}
