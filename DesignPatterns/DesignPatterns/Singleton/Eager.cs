// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Eager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.Singleton
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Eager initialization
    /// </summary>
    public class Eager
    {
        /// <summary>
        /// The object
        /// </summary>
        private static readonly Eager Obj = new Eager();

        /// <summary>
        /// Prevents a default instance of the <see cref="Eager"/> class from being created.
        /// </summary>
        private Eager()
        {
        }

        /// <summary>
        /// Get objects this instance.
        /// </summary>
        /// <returns>
        /// Returns the object
        /// </returns>
        public static Eager Getobject()
        {
            return Obj;
        }
    }
}