// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Lazy.cs" company="Bridgelabz">
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
    /// Lazy initialization.
    /// </summary>
    public class Lazy
    {
        /// <summary>
        /// Object declaration.
        /// </summary>
        private static Lazy obj;

        /// <summary>
        /// Prevents a default instance of the <see cref="Lazy"/> class from being created.
        /// </summary>
        private Lazy()
        {
        }

        /// <summary>
        /// Get objects this instance.
        /// </summary>
        /// <returns>
        /// Returns the object.
        /// </returns>
        public static Lazy GetObject()
        {
            if (obj == null)
            {
                obj = new Lazy();
            }

            return obj;
        }
    }
}
