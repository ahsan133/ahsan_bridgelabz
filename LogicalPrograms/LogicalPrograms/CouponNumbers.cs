// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CouponNumbers.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class CouponNumbers
    {
        public static void CouponNumbersObj()
        {
            var chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ123456789".ToCharArray();
            int max = 100000000;
            int random = Utility.RandomInt(0,max);
            StringBuilder s = new StringBuilder();
            while(random>0)
            {
                //take random characters and add to the string
                s.Append(chars[random % chars.Length]);
                random /= 10;
            }
            Console.WriteLine(s.ToString());
        }
    }
}
