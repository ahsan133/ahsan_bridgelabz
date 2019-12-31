// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TicTacToe.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace LogicalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// TicTacToe program with computer and user
    /// </summary>
    public class TicTacToe
    {
        /// <summary>
        /// Prints the specified array.
        /// </summary>
        /// <param name="array">The array.</param>
        public static void Print(char[,] array)
        {
            Console.WriteLine(array[0, 0] + " " + array[0, 1] + " " + array[0, 2]);
            Console.WriteLine(array[1, 0] + " " + array[1, 1] + " " + array[1, 2]);
            Console.WriteLine(array[2, 0] + " " + array[2, 1] + " " + array[2, 2]);
            Console.WriteLine("------");
        }

        /// <summary>
        /// Users the input.
        /// </summary>
        /// <param name="row">The row.</param>
        /// <param name="column">The column.</param>
        /// <param name="array">The array.</param>
        /// <returns>
        /// Returns the array
        /// </returns>
        public static char[,] UserInput(int row, int column, char[,] array)
        {
            array[row, column] = 'x';
            return array;
        }

        /// <summary>
        /// Computers the input.
        /// </summary>
        /// <param name="row">The row.</param>
        /// <param name="column">The column.</param>
        /// <param name="array">The array.</param>
        /// <returns>
        /// Returns the array
        /// </returns>
        public static char[,] ComputerInput(int row, int column, char[,] array)
        {
            array[row, column] = 'o';
            return array;
        }

        /// <summary>
        /// Tics the tac toe object.
        /// </summary>
        public static void TicTacToeObj()
        {
            int turn = 0, row = 0, column = 0;
            bool win = false;
            char[,] array = { { ' ', ' ', ' ' }, { ' ', ' ', ' ', }, { ' ', ' ', ' ', } };
            while (turn != 9 || win)
            {
                if (turn != 9 && !win)
                {
                    Console.WriteLine("enter your move");
                    Console.WriteLine("enter the row 0-2");
                    row = Utility.InputForTicTacToe(Console.ReadLine());
                    Console.WriteLine("enter the column 0-2");
                    column = Utility.InputForTicTacToe(Console.ReadLine());
                    while ((array[row, column] == 'x') || (array[row, column] == 'o'))
                    {
                        Console.WriteLine("invalid move");
                        Console.WriteLine("enter the row 0-2");
                        row = Utility.InputForTicTacToe(Console.ReadLine());
                        Console.WriteLine("enter the column 0-2");
                        column = Utility.InputForTicTacToe(Console.ReadLine());
                    }

                    array = UserInput(row, column, array);
                    Print(array);
                }
                ////check winning condition for user
                if ((array[0, 0] == 'x' && array[0, 1] == 'x' && array[0, 2] == 'x') || (array[1, 0] == 'x' && array[1, 1] == 'x' && array[1, 2] == 'x') ||
                    (array[2, 0] == 'x' && array[2, 1] == 'x' && array[2, 2] == 'x') || (array[0, 0] == 'x' && array[1, 0] == 'x' && array[2, 0] == 'x') ||
                    (array[0, 1] == 'x' && array[1, 1] == 'x' && array[2, 1] == 'x') || (array[0, 2] == 'x' && array[1, 2] == 'x' && array[2, 2] == 'x') ||
                    (array[0, 0] == 'x' && array[1, 1] == 'x' && array[2, 2] == 'x') || (array[0, 2] == 'x' && array[1, 1] == 'x' && array[2, 0] == 'x'))
                {
                    Console.WriteLine("you win");
                    win = true;
                    break;
                }

                turn++;
                if (turn != 9 && !win)
                {
                    row = (int)Utility.RandomInt(0, 2);
                    column = (int)Utility.RandomInt(0, 2);
                    while ((array[row, column] == 'x') || (array[row, column] == 'o'))
                    {
                        row = (int)Utility.RandomInt(0, 2);
                        column = (int)Utility.RandomInt(0, 2);
                    }

                    array = ComputerInput(row, column, array);
                    Print(array);
                    ////check winning condition for computer
                    if ((array[0, 0] == 'o' && array[0, 1] == 'o' && array[0, 2] == 'o') || (array[1, 0] == 'o' && array[1, 1] == 'o' && array[1, 2] == 'o') ||
                        (array[2, 0] == 'o' && array[2, 1] == 'o' && array[2, 2] == 'o') || (array[0, 0] == 'o' && array[1, 0] == 'o' && array[2, 0] == 'o') ||
                        (array[0, 1] == 'o' && array[1, 1] == 'o' && array[2, 1] == 'o') || (array[0, 2] == 'o' && array[1, 2] == 'o' && array[2, 2] == 'o') ||
                        (array[0, 0] == 'o' && array[1, 1] == 'o' && array[2, 2] == 'o') || (array[0, 2] == 'o' && array[1, 1] == 'o' && array[2, 0] == 'o'))
                    {
                        Console.WriteLine("computer wins");
                        win = true;
                        break;
                    }

                    turn++;
                }
            }
            ////check draw condition
            if (!win || turn == 9)
            {
                Console.WriteLine("draw");
            }
        }
    }
}