// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TwoDArray.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class TwoDArray
    {
        public static void twodarray()
        {
            Console.WriteLine("enter number of rows");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number of columns");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[M,N];
            Console.WriteLine("enter the elements");
            for(int i=0;i<M;i++)
            {
                for(int j=0;j<N;j++)
                {
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //print the array
            for (int i = 0; i < M; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < N; j++)
                {
                    Console.Write(array[i,j]+" ");
                }
            }

        }
    }
}
