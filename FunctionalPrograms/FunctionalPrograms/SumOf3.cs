// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SumOf3.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class SumOf3
    {
        public static void sumof3()
        {
            int count = 0;
            Console.WriteLine("enter number of integers");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("enter "+n+" integers");
            for(int i=0;i<n;i++)
                a[i]= Convert.ToInt32(Console.ReadLine());
            //take random numbers
            for (int i = 0; i < n-2; i++)
            {
                for (int j = i+1; j < n-1; j++)
                {
                    for (int k = j+1; k < n; k++)
                    {
                        //check if sum of three numbers is 0
                        if(a[i]+a[j]+a[k]==0)
                        {
                            Console.WriteLine(a[i] + " " + a[j] + " " + a[k] + " ");
                            count += 3;
                        }                           
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
