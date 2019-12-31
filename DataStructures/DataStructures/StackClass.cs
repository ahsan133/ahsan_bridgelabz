// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StackClass.cs" company="Bridgelabz">
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
    /// Stack class
    /// </summary>
    /// <typeparam name="T">Any datatype.</typeparam>
    public class StackClass<T>
    {
        public T[] present;
        public int max;
        public int top;

        /// <summary>
        /// Initializes a new instance of the <see cref="StackClass{T}"/> class.
        /// </summary>
        /// <param name="size">The size.</param>
        public StackClass(int size)
        {
            max = size;
            top = -1;
            present = new T[size];
        }

        /// <summary>
        /// Pushes the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        public void push(T data)
        {
            if (top == max - 1)
            {
                Console.WriteLine("stack overflow");
                return;
            }
            else
            {
                present[++top] = data;
            }
        }

        /// <summary>
        /// Pops this instance.
        /// </summary>
        public void Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("stack is empty");
                return;
            }
            else
            {
                --top;
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
            if (top < 0)
            {
                return true;
            }
            else
            {
                return false;
            }                           
        }

        /// <summary>
        /// Prints this instance.
        /// </summary>
        public void Print()
        {
            while (top >= 0)
            {
                Console.Write(present[--top] + " ");
            }
        }
    }
}
