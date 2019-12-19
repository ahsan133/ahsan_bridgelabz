// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InsertionSort.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class InsertionSort
    {
        public static void InsertionSortObj()
        {
            Console.WriteLine("enter the size");
            int n = Utility.IsInteger(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("enter the elements");
            for (int i = 0; i < n; i++)
            array[i] = Utility.IsInteger(Console.ReadLine());
            //Sorting the array
            for (int i = 1; i < n; i++)
            {
                int key = array[i];
                int j = i - 1;
                while (j >= 0 && key < array[j])
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = key;
            }
            for (int i = 0; i < n; i++)
                Console.WriteLine(array[i] + " ");
        }
    }
}
