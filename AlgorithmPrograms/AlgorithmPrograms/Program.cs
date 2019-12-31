// --------------------------------------------------------------------------------------------------------------------
// <copyright file="program.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace AlgorithmPrograms
{
    using System;

    /// <summary>
    /// Main function
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("1.permutation\n2.binary search\n3.Bubble sort\n4.Insertion Sort\n5.Anagram\n6.Prime numbers\n7.Prime Anagram And Palindrome\n8.FindTheNumber\n9.Mergesort");
            Console.WriteLine("Enter your choice");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Permutations permutations = new Permutations();
                    Permutations.PermutationsObj();
                    break;
                case 2:
                    BinarySearch binarySearch = new BinarySearch();
                    BinarySearch.BinarySearchObj();
                    break;
                case 3:
                    BubbleSort bubbleSort = new BubbleSort();
                    BubbleSort.BubbleSortObj();
                    break;
                case 4:
                    InsertionSort insertionSort = new InsertionSort();
                    InsertionSort.InsertionSortObj();
                    break;
                case 5:
                    Anagram anagram = new Anagram();
                    Anagram.AnagramObj();
                    break;
                case 6:
                    PrimeNumbers primeNumbers = new PrimeNumbers();
                    PrimeNumbers.PrimeNumbersObj();
                    break;
                case 7:
                    PrimeAnagramAndPalindrome primeAnagramAndPalindrome = new PrimeAnagramAndPalindrome();
                    PrimeAnagramAndPalindrome.PrimePalindromeAndAnagram();
                    break;
                case 8:
                    FindTheNumber findTheNumber = new FindTheNumber();
                    FindTheNumber.FindTheNumberObj();
                    break;
                case 9:
                    MergeSort mergeSort = new MergeSort();
                    MergeSort.MergeSortObj();
                    break;
                default:
                    break;
            }
        }
    }
}
