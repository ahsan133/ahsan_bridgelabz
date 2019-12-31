// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BubbleSort.cs" company="Bridgelabz">
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
    /// Bubble sorting
    /// </summary>
    public class BubbleSort
    {
        /// <summary>
        /// Bubbles the sort object.
        /// </summary>
        public static void BubbleSortObj()
        {
            Console.WriteLine("enter the size");
            int size = Utility.IsInteger(Console.ReadLine());
            int[] array = new int[size];
            Console.WriteLine("enter the elements");
            for (int i = 0; i < size; i++)
            {
                array[i] = Utility.IsInteger(Console.ReadLine());
            }           
            ////sorting the array
            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (array[j] < array[i])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(array[i] + " ");
            }
        }
    }
}       