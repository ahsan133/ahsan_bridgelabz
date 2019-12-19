// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BubbleSort.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class BubbleSort
    { 
        public static void BubbleSortObj()
        {
            Console.WriteLine("enter the size");
            int n = Utility.IsInteger(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("enter the elements");
            for(int i=0;i<n;i++)
            array[i]= Utility.IsInteger(Console.ReadLine());
            //sorting the array
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[i])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            for (int i = 0; i < n; i++)
                Console.WriteLine(array[i] + " ");
        }
    }

}
    

        
