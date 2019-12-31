// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HarmonicNumber.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace BasicProgram
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using BasicPrograms;

    /// <summary>
    /// Harmonic of a number
    /// </summary>
    public class HarmonicNumber
    {
        /// <summary>
        /// Harmonics the number object.
        /// </summary>
        public static void HarmonicNumberObj()
        {
            double harmonic = 0;
            Console.WriteLine("enter the number");
            int num = Utility.IsInteger(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                harmonic += 1.0 / i;
            }
            
            Console.WriteLine("harmonic of " + num + " is " + harmonic);
        }
    }
}
