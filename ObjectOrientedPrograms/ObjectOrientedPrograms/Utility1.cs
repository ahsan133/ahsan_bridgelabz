// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Utility1.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Utility1 Class
    /// </summary>
    public class Utility1
    {
        /// <summary>
        /// Randoms the int.
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <returns>
        /// Returns a random integer value
        /// </returns>
        public static int RandomInt(int min, int max)
        {
            Random rand = new Random();
            return rand.Next(min, max + 1);
        }
    }
}