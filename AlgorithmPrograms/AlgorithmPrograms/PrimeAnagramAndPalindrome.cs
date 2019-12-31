// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PrimeAnagramAndPalindrome.cs" company="Bridgelabz">
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
    /// Prime anagram and palindrome
    /// </summary>
    public class PrimeAnagramAndPalindrome
    {
        /// <summary>
        /// Palindrome of prime numbers
        /// </summary>
        /// <param name="array">
        /// Finds the palindrome
        /// </param>
        public static void Palindrome(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                {
                    int q = 0, temp = array[i];
                    while (array[i] != 0)
                    {
                        int p = array[i] % 10;
                        q = (q * 10) + p;
                        array[i] /= 10;
                    }

                    if (q == temp)
                    {
                        Console.WriteLine("palindrome: " + temp);
                    }                       
                }             
            }
        }

        /// <summary>
        /// Anagram of prime numbers
        /// </summary>
        /// <param name="array">
        /// Finds the anagram
        /// </param>
        public static void Anagram(int[] array)
        {
            int[] a = new int[10];
            int[] b = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    for (int l = 0; l < 10; l++)
                    {
                        a[l] = 0;
                        b[l] = 0;
                    }

                    if ((array[i] != 0) && (array[j] != 0))
                    {
                        int count1 = 0, count2 = 0, c = 0;
                        int temp1 = array[i], temp2 = array[j];
                        while (array[i] != 0)
                        {
                            int n = array[i] % 10;
                            a[n]++;
                            count1++;
                            array[i] /= 10;
                        }

                        while (array[j] != 0)
                        {
                            int m = array[j] % 10;                          
                            b[m]++;
                            count2++;
                            array[j] /= 10;
                        }

                        if (count1 != count2)
                        {
                            continue;
                        }                            
                        else
                        {
                            for (int k = 0; k < 10; k++)
                            {                               
                                if (a[k] == b[k])
                                {
                                    c++;
                                }                                  
                            }

                            array[i] = temp1;
                            array[j] = temp2;
                            if (c == 10)
                            {
                                Console.WriteLine("anagrams: " + temp1 + " and " + temp2);
                            }
                        }
                    }     
                }                             
            }
        }

        /// <summary>
        /// Main function
        /// </summary>
        public static void PrimePalindromeAndAnagram()
        {
            int k = 0;
            Console.WriteLine("enter the range 0-1000");
            int min = Utility.IsInteger(Console.ReadLine());
            int max = Utility.IsInteger(Console.ReadLine());
            int[] array = new int[1000];
            int[] array1 = new int[1000];
            while (min < max)
            {
                bool flag = false;
                for (int i = 2; i <= min / 2; ++i)
                {
                    if (min % i == 0)
                    {
                        flag = true;
                        break;
                    }
                }

                if (!flag)
                {
                    array1[k] = min;
                    array[k] = min;
                    k++;
                    Console.WriteLine(min + " ");
                }

                ++min;               
            }

            Palindrome(array);
            Anagram(array1); 
        }
    }
}
