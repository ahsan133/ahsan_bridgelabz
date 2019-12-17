﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="program.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
using System;

namespace AlgorithmPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("1.permutation\n2.binary search\n3.Bubble sort\n4.Insertion Sort\n5.Anagram\n6.Prime numbers\n7.Prime Anagram And Palindrome\n8.FindTheNumber");
            Console.WriteLine("Enter your choice");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Permutations Permutations = new Permutations();
                    Permutations.permutation();
                    break;
                case 2:
                    BinarySearch BinarySearch = new BinarySearch();
                    BinarySearch.binarysearch();
                    break;
                case 3:
                    BubbleSort BubbleSort = new BubbleSort();
                    BubbleSort.bubblesort();
                    break;
                case 4:
                    InsertionSort InsertionSort = new InsertionSort();
                    InsertionSort.insertionsort();
                    break;
                case 5:
                    Anagram Anagram = new Anagram();
                    Anagram.anagram();
                    break;
                case 6:
                    PrimeNumbers PrimeNumbers = new PrimeNumbers();
                    PrimeNumbers.prime();
                    break;
                case 7:
                    PrimeAnagramAndPalindrome PrimeAnagramAndPalindrome = new PrimeAnagramAndPalindrome();
                    PrimeAnagramAndPalindrome.pnam();
                    break;
                case 8:
                    FindTheNumber FindTheNumber = new FindTheNumber();
                    FindTheNumber.findthenumber();
                    break;


                default:
                    break;
            }
        }
    }
}
