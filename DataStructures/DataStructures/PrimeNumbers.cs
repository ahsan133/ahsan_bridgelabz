using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class PrimeNumbers
    {
        public static void PrimeNumbersObj()
        {
            int[,] array = new int[100, 1000];            
            int j = 100;           
            for (int i=0;i<10;i++)
            {
                int k = 0;
                int[] arr = new int[1000];
                array[i, k] = j;
                arr = Utility.PrimeNumbers(j - 100, j);
                int m = 1;
                for(int p=0;p<arr.Length;p++)
                {
                    array[i, m] = arr[p];
                    m++;
                }
                j += 100;
            }
            for (int i=0;i<10;i++)
            {
                Console.WriteLine();
                for (int l = 0; l < 100; l++)
                {
                    if(array[i,l]!=0)
                    Console.Write(array[i,l]+" ");
                }
            }
        }
    }
}
