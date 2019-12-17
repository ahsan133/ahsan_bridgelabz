// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FindTheNumber.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class FindTheNumber
    {
        public static void num(int lo,int hi)
        {
            int mid = lo + (hi - lo) / 2;
            if( (lo!=mid) || (mid!=hi) )
            {
                while (lo <= hi)
                {
                    Console.WriteLine("is your number " + mid);
                    Console.WriteLine("enter 1 for yes and 0 for no");
                    int rs = Convert.ToInt32(Console.ReadLine());
                    if (rs != 1)
                    {
                        Console.WriteLine("is your number between " + lo + " and " + mid);
                        Console.WriteLine("enter 1 for yes and 0 for no");
                        int res = Convert.ToInt32(Console.ReadLine());
                        if (res == 1)
                            num(lo, mid);
                        else
                            num(mid + 1, hi);
                    }
                    if(rs==1)
                        break;
                }                          
            }
            else
            {
                Console.WriteLine("your number is " + mid);              
            }
        }
        public static void findthenumber()
        {
            Console.WriteLine("enter the number which power of 2");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("think of a number between 0 and "+n);
            num(0, n);
        }
    }
}
