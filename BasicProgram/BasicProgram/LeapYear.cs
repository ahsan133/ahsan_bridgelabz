// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LeapYear.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace BasicPrograms
{
    using System;

    /// <summary>
    /// Check if the year is leap year or not
    /// </summary>
    public class LeapYear
    {
        /// <summary>
        /// Determines whether the specified year is year.
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns>
        ///   <c>true</c> if the specified year is year; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsYear(int year)
        {
            int count = 0;
            while (year != 0)
            {
                count++;
                year = year / 10;
            }

            if (count == 4)
            {
                return true;
            }                
            else
            {
                return false;
            }               
        }

        /// <summary>
        /// Leaps the year object.
        /// </summary>
        public static void LeapYearObj()
        {
            Console.WriteLine("enter the the year");
            int year = Utility.IsInteger(Console.ReadLine());
            bool fourdigit = IsYear(year);
            while (fourdigit == false)
            {
                Console.WriteLine("enter a four digit number");
            }
            ////check for leap year
            bool flag = Utility.LeapYear(year);
            if (flag)
            {
                Console.WriteLine(year + " is a leap year");
            }                
            else
            {
                Console.WriteLine(year + " is not a leap year");
            }               
        }
    }
}