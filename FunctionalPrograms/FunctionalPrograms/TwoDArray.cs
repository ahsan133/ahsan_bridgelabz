// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TwoDArray.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class TwoDArray
    {
        public static void TwoDArrayObj()
        {
            Console.WriteLine("enter number of rows");
            int M = Utility.IsInteger(Console.ReadLine());
            Console.WriteLine("enter number of columns");
            int N = Utility.IsInteger(Console.ReadLine());
            int[,] array = new int[M,N];
            Console.WriteLine("enter the elements");
            Utility.TwoDArray(M, N);
        }
    }
}