// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Node.cs" company="Bridgelabz">
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
    /// Creating a node
    /// </summary>
    /// <typeparam name="T">Ten node.</typeparam>
    public class Node<T>
    {
        /// <summary>
        /// The data
        /// </summary>
        public T data;

        /// <summary>
        /// The next
        /// </summary>
        public Node<T> next;

        /// <summary>
        /// Initializes a new instance of the <see cref="Node{T}"/> class.
        /// </summary>
        /// <param name="data">The data.</param>
        public Node(T data)
        {
            this.data = data;
            this.next = null;
        }
    }
}