// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// --------------------------------------------------------------------------------------------------------------------
namespace LogicalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Utility Class
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// Determines whether the specified input is integer.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>
        /// Returns the integer value
        /// </returns>
        public static int IsInteger(string input)
        {
            int number;
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

        /// <summary>
        /// Determines whether the specified input is double.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>
        /// Returns the double value
        /// </returns>
        public static double IsDouble(string input)
        {
            double number;
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

        /// <summary>
        /// Determines whether the specified input is string.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>
        /// Returns the string
        /// </returns>
        public static string IsString(string input)
        {
            int flag = 1;
            do
            {
                ////check if the input has whitespace
                if (input.Contains(" "))
                {
                    Console.WriteLine("the string entered has a whitespace. please enter a proper string");
                    input = Console.ReadLine();
                }
                ////check if the input has number or not
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
                    {
                        flag = 0;
                    }
                }
            }
            while (flag == 1);
            return input;
        }

        /// <summary>
        /// Determines whether the specified input is boolean.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>
        ///   <c>true</c> if the specified input is boolean; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsBoolean(string input)
        {
            input.ToLower();
            ////check the value of input if its true or false
            while (string.Equals(input, "true") != true && string.Equals(input, "false") != true)
            {
                input.ToLower();
                Console.WriteLine("please enter a boolean value");
                input = Console.ReadLine();
            }

            return input.Equals("true") ? true : false;
        }

        /// <summary>
        /// Twos the d array.
        /// </summary>
        /// <param name="row">The row.</param>
        /// <param name="column">The column.</param>
        /// <returns>
        /// Returns the 2D array
        /// </returns>
        public static int[,] TwoDArray(int row, int column)
        {
            int[,] array = new int[row, column];
            ////read the array
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    array[i, j] = Utility.IsInteger(Console.ReadLine());
                }
            }
            ////print the array
            for (int i = 0; i < row; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < column; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
            }

            return array;
        }

        /// <summary>
        /// Randoms the double.
        /// </summary>
        /// <returns>
        /// Returns a random double value
        /// </returns>
        public static double RandomDouble()
        {
            Random rand = new Random();
            return rand.NextDouble();
        }

        /// <summary>
        /// Randoms the int.
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <returns>
        /// Returns a random integer value
        /// </returns>
        public static int RandomInt(int min, int max)
        {
            Random rand = new Random();
            return rand.Next(min, max + 1);
        }

        /// <summary>
        /// Inputs for tic tac toe.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>
        /// Returns the move
        /// </returns>
        public static int InputForTicTacToe(string input)
        {
            int move = Utility.IsInteger(input);
            if (move == 0 || move == 1 || move == 2)
            {
                return move;
            }               
            else
            {
                while (move != 0 && move != 1 && move != 2)
                {
                    Console.WriteLine("enter the valid input");
                    string s = Console.ReadLine();
                    move = Utility.IsInteger(s);
                }

                return move;
            }
        }
    } 
}