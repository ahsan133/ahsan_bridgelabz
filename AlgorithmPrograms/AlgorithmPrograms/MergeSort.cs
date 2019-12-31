// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MergeSort.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// --------------------------------------------------------------------------------------------------------------------
namespace AlgorithmPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Sorting using merge sort
    /// </summary>
    public class MergeSort
    {
        /// <summary>
        /// Merges the specified array.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <param name="low">The low.</param>
        /// <param name="mid">The mid.</param>
        /// <param name="high">The high.</param>
        public static void Merge(int[] array, int low, int mid, int high)
        {
            int i, j, k;
            int n1 = mid - low + 1;
            int n2 = high - mid;
            int[] left = new int[n1];
            int[] right = new int[n2];
            for (i = 0; i < n1; i++)
            {
                left[i] = array[low + i];
            }

            for (j = 0; j < n2; j++)
            {
                right[j] = array[mid + 1 + j];
            }

            i = 0;
            j = 0;
            k = low;
            while (i < n1 && j < n2)
            {
                if (left[i] <= right[j])
                {
                    array[k] = left[i];
                    i++;
                }
                else
                {
                    array[k] = right[j];
                    j++;
                }

                k++;
            }

            while (i < n1)
            {
                array[k] = left[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                array[k] = right[j];
                j++;
                k++;
            }
        }

        /// <summary>
        /// Sorts the specified array.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <param name="low">The low.</param>
        /// <param name="high">The high.</param>
        public static void Sort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int mid = (low + high) / 2;
                Sort(array, low, mid);
                Sort(array, mid + 1, high);
                Merge(array, low, mid, high);
            }
        }

        /// <summary>
        /// Merges the sort object.
        /// </summary>
        public static void MergeSortObj()
        {
            int[] array = { 76, 89, 23, 1, 55, 78, 99, 12, 65, 100 };
            int length = 10, i;
            Console.WriteLine("Merge Sort");
            Console.Write("Initial array is: ");
            for (i = 0; i < length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Sort(array, 0, length - 1);
            Console.Write("\nSorted Array is: ");
            for (i = 0; i < length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
