// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StopWatch.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------

namespace LogicalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Implementing StopWatch
    /// </summary>
    public class StopWatch
    {
        /// <summary>
        /// Stops the watch object.
        /// </summary>
        public static void StopWatchObj()
        {
            int start = DateTime.Now.Second;
            Console.WriteLine("Timer started, Press Enter to stop");
            Console.ReadLine();
            int stop = DateTime.Now.Second;
            Console.WriteLine("elapsed time is " + (stop - start) + " seconds");
        }
    }
}