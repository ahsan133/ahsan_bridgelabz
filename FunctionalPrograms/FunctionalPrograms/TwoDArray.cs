// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TwoDArray.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Read and print 2D array
    /// </summary>
    public class TwoDArray
    {
        /// <summary>
        /// Twos the d array object.
        /// </summary>
        public static void TwoDArrayObj()
        {
            Console.WriteLine("enter number of rows");
            int row = Utility.IsInteger(Console.ReadLine());
            Console.WriteLine("enter number of columns");
            int column = Utility.IsInteger(Console.ReadLine());
            int[,] array = new int[row, column];
            Console.WriteLine("enter the elements");
            Utility.TwoDArray(row, column);
        }
    }
}