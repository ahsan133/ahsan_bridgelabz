// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InsertionSort.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace AlgorithmPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Sorting using insertion sort
    /// </summary>
    public class InsertionSort
    {
        /// <summary>
        /// Insertions the sort object.
        /// </summary>
        public static void InsertionSortObj()
        {
            Console.WriteLine("enter the size");
            int size = Utility.IsInteger(Console.ReadLine());
            int[] array = new int[size];
            Console.WriteLine("enter the elements");
            for (int i = 0; i < size; i++)
            {
                array[i] = Utility.IsInteger(Console.ReadLine());
            }           
            ////Sorting the array
            for (int i = 1; i < size; i++)
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

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(array[i] + " ");
            }                
        }
    }
}