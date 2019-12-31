// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DequeClass.cs" company="Bridgelabz">
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
    /// Deque implementation
    /// </summary>
    /// <typeparam name="T">Any datatype.</typeparam>
    public class DequeClass<T>
    {
        int front = 0;
        int rear = 0;
        T[] deque;

        /// <summary>
        /// Initializes a new instance of the <see cref="DequeClass{T}"/> class.
        /// </summary>
        /// <param name="size">The size.</param>
        public DequeClass (int size)
        {
            deque = new T[size + 1];
        }

        /// <summary>
        /// Adds the front.
        /// </summary>
        /// <param name="data">The data.</param>
        public void AddFront(T data)
        {
            if (rear <= 0)
            {
                deque[++rear] = data;
                return;
            }
            else
            {
                for (int i = rear; i > 0; i--)
                    deque[i + 1] = deque[i];
                deque[1] = data;
                rear += 1;
            }
        }

        /// <summary>
        /// Adds the rear.
        /// </summary>
        /// <param name="data">The data.</param>
        public void AddRear(T data)
        {
            if (rear <= 0)
            {
                deque[++rear] = data;
                return;
            }
            else
                deque[++rear] = data;
        }

        /// <summary>
        /// Removes the front.
        /// </summary>
        public void RemoveFront()
        {
            if (rear <= 0)
            {
                Console.WriteLine("deque is empty");
                return;
            }
            else
            {
                for (int i = 1; i < rear; i++)
                {
                    deque[i] = deque[i + 1];
                }
                rear--;
            }
        }

        /// <summary>
        /// Removes the rear.
        /// </summary>
        public void RemoveRear()
        {
            if (rear <= 0)
            {
                Console.WriteLine("deque is empty");
                return;
            }
            else
            {
                --rear;
            }             
        }

        /// <summary>
        /// Peeks the rear.
        /// </summary>
        /// <returns>
        /// Returns the front deque value
        /// </returns>
        public T PeekRear()
        {
            return deque[rear];
        }

        /// <summary>
        /// Prints this instance.
        /// </summary>
        public void Print()
        {
            for (int i = 1; i <= rear; i++)
            {
                Console.Write(deque[i] + " ");
            }
            
            Console.WriteLine();
        }
    }
}
