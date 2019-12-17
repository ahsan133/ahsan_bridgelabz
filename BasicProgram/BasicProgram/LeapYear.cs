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
       public static bool isYear(int year)
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

      public  static void Leap()
        {
            bool flag = false;
            Console.WriteLine("enter the the year");
            var y = Console.ReadLine();
            int year = Convert.ToInt32(y);
            bool fourdigit = isYear(year);
            if (!fourdigit)
            {
                Console.WriteLine("enter a four digit number");
            }
            else
            {
                //check for leap year
                if (year % 4 == 0)
                {
                    if (year % 100 == 0)
                    {
                        if (year % 400 == 0)
                            flag = true;
                        else
                            flag = false;
                    }
                    else
                        flag = true;
                }
                else
                    flag = false;

                if (flag)
                    Console.WriteLine(year + " is a leap year");
                else
                    Console.WriteLine(year + " is not a leap year");
            }
        }

       
    }
}