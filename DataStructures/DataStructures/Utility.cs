// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Utility
    {
        public static int IsInteger(string input)
        {
            int number;
            //check the value of input if its a number or not
            if (int.TryParse(input, out number))
            {
                return Convert.ToInt32(input);
            }
            else
            {
                while (int.TryParse(input, out number) == false)
                {
                    Console.WriteLine("please enter a proper integer");
                    input = Console.ReadLine();
                }
                return Convert.ToInt32(input);
            }
        }

        public static double IsDouble(string input)
        {
            double number;
            //check the value of input if a number is decimal or not
            if (double.TryParse(input, out number))
            {
                return number;
            }
            else
            {
                while (double.TryParse(input, out number) == false)
                {
                    Console.WriteLine("please enter a proper integer");
                    input = Console.ReadLine();
                }
                return number;
            }
        }

        public static string IsString(string input)
        {
            int flag = 1;
            do
            {
                //check if the input has whitespace
                if (input.Contains(" "))
                {
                    Console.WriteLine("the string entered has a whitespace. please enter a proper string");
                    input = Console.ReadLine();
                }
                //check if the input has number or not
                for (int i = 0; i < 10; i++)
                {
                    if (input.Contains(i.ToString()))
                    {
                        flag = 1;
                        Console.WriteLine("the string entered has a number. please enter a proper string");
                        input = Console.ReadLine();
                        break;
                    }
                    else
                        flag = 0;
                }
            } while (flag == 1);
            return input;
        }

        public static bool IsBoolean(string input)
        {
            input.ToLower();
            //check the value of input if its true or false
            while (String.Equals(input, "true") != true && String.Equals(input, "false") != true)
            {
                input.ToLower();
                Console.WriteLine("please enter a boolean value");
                input = Console.ReadLine();
            }
            return input.Equals("true") ? true : false;
        }

        //read and print 2D array
        public static int[,] TwoDArray(int m, int n)
        {
            int[,] array = new int[m, n];
            //read the array
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                    array[i, j] = Utility.IsInteger(Console.ReadLine());
            }
            //print the array
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < n; j++)
                    Console.Write(array[i, j] + " ");
            }
            return array;
        }

        public static double RandomDouble()
        {
            Random rand = new Random();
            return rand.NextDouble();
        }

        public static int RandomInt(int min, int max)
        {
            Random rand = new Random();
            return rand.Next(min, max + 1);
        }

        public static bool LeapYear(int year)
        {
            bool flag = false;
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                        flag = true;
                    else
                        flag = false;
                }
                else
                    flag = true;
            }
            else
                flag = false;

            if (flag)
                return true;
            else
                return false;
        }

        public static int[] PrimeNumbers(int min, int max)
        {
            int[] arr = new int[1000];
            int k = 0, count = 0;
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
                    if(min!=0 && min!=1)
                    {
                        count++;
                        arr[k++] = min;
                    }                
                }
                ++min;
            }
            int[] array = new int[count];
            for (int j = 0; j < count; j++)
                array[j] = arr[j];
            return array;
        }
        public static bool Anagram(int num1,int num2)
        {
            int[] a = new int[10];
            int[] b = new int[10];
            int count1 = 0;
            int count2 = 0;
            int c = 0;
            while (num1 != 0)
            {
                int n = num1 % 10;
                a[n]++;
                count1++;
                num1 /= 10;
            }
            while (num2 != 0)
            {
                int m = num2 % 10;
                b[m]++;
                count2++;
                num2 /= 10;
            }
            if (count1 != count2)
                return false;
            else
            {
                for (int k = 0; k < 10; k++)
                {
                    if (a[k] == b[k])
                        c++;
                }
                if (c == 10)
                    return true;
            }
            return false;
        }
    }
}
