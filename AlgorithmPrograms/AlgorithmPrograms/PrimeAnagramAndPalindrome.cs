// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PrimeAnagramAndPalindrome.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class PrimeAnagramAndPalindrome
    {
        // find palindrome of prime numbers 
        public static void Palindrome(int[] a)
        {
            for (int i=0;i<a.Length;i++)
            {
                if(a[i]!=0)
                {
                    int q = 0,temp = a[i];
                    while (a[i] != 0)
                    {
                        int p = a[i] % 10;
                        q = (q * 10) + p;
                        a[i] /= 10;
                    }
                    if (q == temp)
                        Console.WriteLine("palindrome: " + temp);
                }             
            }
        }
        //find anagram of prime numbers
        public static void Anagram(int[] arr)
        {
            int[] a = new int[10];
            int[] b = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                for(int j=(i+1) ; j<arr.Length ; j++)
                {
                    for(int l=0;l<10;l++)
                    {
                        a[l] = 0;
                        b[l] = 0;
                    }
                    if ((arr[i]!=0)&&(arr[j]!=0))
                    {
                        int count1 = 0, count2 = 0, c = 0;
                        int temp1 = arr[i], temp2 = arr[j];
                        while (arr[i] != 0)
                        {
                            int n = arr[i] % 10;
                            a[n]++;
                            count1++;
                            arr[i] /= 10;
                        }
                        while (arr[j] != 0)
                        {
                            int m = arr[j] % 10;                          
                            b[m]++;
                            count2++;
                            arr[j] /= 10;
                        }
                        if (count1 != count2)
                            continue;
                        else
                        {
                            for (int k = 0; k < 10; k++)
                            {                               
                                if (a[k] == b[k])
                                    c++;
                            }
                            arr[i] = temp1;
                            arr[j] = temp2;
                            if (c == 10)
                            {
                                Console.WriteLine("anagrams: " + temp1 + " and " + temp2);
                            }
                        }
                    }     
                }                             
            }
        }
        public static void PrimePalindromeAndAnagram()
        {
            int k = 0;
            Console.WriteLine("enter the range 0-1000");
            int f = Utility.IsInteger(Console.ReadLine());
            int t = Utility.IsInteger(Console.ReadLine());
            int[] arr = new int[1000];
            int[] ar = new int[1000];
            while (f < t)
            {
                bool flag = false;
                for (int i = 2; i <= f / 2; ++i)
                {
                    if (f % i == 0)
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    ar[k] = f;
                    arr[k] = f;
                    k++;
                    Console.WriteLine(f + " ");
                }
                ++f;               
            }
            Palindrome(arr);
            Anagram(ar); 
        }
    }
}
