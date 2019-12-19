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
        public static void Number(int lo,int hi)
        {
            int mid = lo + (hi - lo) / 2;
            if( (lo!=mid) || (mid!=hi) )
            {
                while (lo <= hi)
                {
                    Console.WriteLine("is your number " + mid);
                    Console.WriteLine("enter 1 for yes and 0 for no");
                    int rs = Utility.IsInteger(Console.ReadLine());
                    if (rs != 1)
                    {
                        Console.WriteLine("is your number between " + lo + " and " + mid);
                        Console.WriteLine("enter 1 for yes and 0 for no");
                        int res = Utility.IsInteger(Console.ReadLine());
                        if (res == 1)
                            Number(lo, mid);
                        else
                            Number(mid + 1, hi);
                    }
                    else                        
                        break;
                    //break out of while loop 
                    break;
                }                          
            }
            else
            {
                Console.WriteLine("your number is " + mid);              
            }
        }
        public static void FindTheNumberObj()
        {
            Console.WriteLine("enter the number which power of 2");
            int n = Utility.IsInteger(Console.ReadLine());
            Console.WriteLine("think of a number between 0 and "+n);
            Number(0, n);
        }
    }
}
