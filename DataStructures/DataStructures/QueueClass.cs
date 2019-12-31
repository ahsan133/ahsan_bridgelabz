// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QueueClass.cs" company="Bridgelabz">
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
    /// Queue class
    /// </summary>
    /// <typeparam name="T">Any datatype.</typeparam>
    class QueueClass<T>
    {
        public int first = 0;
        public int last = 0;
        public T[] queue;

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueClass{T}"/> class.
        /// </summary>
        /// <param name="size">The size.</param>
        public QueueClass(int size)
        {
            queue = new T[size + 1];
        }

        /// <summary>
        /// Adds the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        public void Add(T data)
        {
            queue[++last] = data;
        }

        /// <summary>
        /// Removes this instance.
        /// </summary>
        public void Remove()
        {
            if (last == 0)
            {
                Console.WriteLine("queue is empty");
                return;
            }

            for (int i = 1; i < last; i++)
            {
                queue[i] = queue[i + 1];
            }

            last--;
        }

        /// <summary>
        /// Prints this instance.
        /// </summary>
        public void Print()
        {
            for (int i = 1; i <= last; i++)
            {
                Console.Write(queue[i] + " ");
            }
            
            Console.WriteLine();
        }
    }  
}
