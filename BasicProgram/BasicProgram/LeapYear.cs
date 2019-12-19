// --------------------------------------------------------------------------------------------------------------------
// <copyright file="leapYear.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
using System;

namespace BasicPrograms
{
   public class leapYear
    {
        
        //Check for four digit number
       public static bool IsYear(int year)
        {
            int count = 0;
            while (year != 0)
            {
                count++;
                year = year / 10;
            }
            if (count == 4)
                return true;
            else
                return false;
        }

      public  static void LeapYearObj()
        {
            Console.WriteLine("enter the the year");
            int year = Utility.IsInteger(Console.ReadLine());
            bool fourdigit = IsYear(year);
            while(fourdigit==false)
            {
                Console.WriteLine("enter a four digit number");
            }
            //check for leap year
            bool flag = Utility.LeapYear(year);

                if (flag)
                    Console.WriteLine(year + " is a leap year");
                else
                    Console.WriteLine(year + " is not a leap year");            
      } 
   }
}