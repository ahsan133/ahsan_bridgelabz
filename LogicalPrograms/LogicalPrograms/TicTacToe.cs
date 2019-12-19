// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TicTacToe.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class TicTacToe
    {
        //Print the board
        public static void Print(char[,] ar)
        {
            Console.WriteLine(ar[0,0] + " " + ar[0,1] + " " + ar[0,2]);
            Console.WriteLine(ar[1,0] + " " + ar[1,1] + " " + ar[1,2]);
            Console.WriteLine(ar[2,0] + " " + ar[2,1] + " " + ar[2,2]);
            Console.WriteLine("------");
        }
        //assign 'x' to the array
        public static char[,] UserInput(int row, int column, char[,] a)
        {
            a[row,column] = 'x';
            return a;
        }
        //assign 'o' to the array
        public static char[,] ComputerInput(int row, int column, char[,] a)
        {
            a[row,column] = 'o';
            return a;
        }
        public static void TicTacToeObj()
        {
            int turn = 0, row = 0, col = 0;
            bool win = false;
            char[,] a = { { ' ', ' ', ' ' }, { ' ', ' ', ' ', }, { ' ', ' ', ' ', } };
            while ((turn != 9) || (win))
            {
                if ((turn != 9) && (!win))
                {
                    Console.WriteLine("enter your move");
                    Console.WriteLine("enter the row 0-2");
                    row = Utility.InputForTicTacToe(Console.ReadLine());
                    Console.WriteLine("enter the column 0-2");
                    col = Utility.InputForTicTacToe(Console.ReadLine());

                    while ((a[row, col] == 'x') || (a[row, col] == 'o'))
                    {
                        Console.WriteLine("invalid move");
                        Console.WriteLine("enter the row 0-2");
                        row = Utility.InputForTicTacToe(Console.ReadLine());
                        Console.WriteLine("enter the column 0-2");
                        col = Utility.InputForTicTacToe(Console.ReadLine());
                    }
                    a = UserInput(row, col, a);
                    Print(a);
                }
                //check winning condition for user
                if ((a[0, 0] == 'x' && a[0, 1] == 'x' && a[0, 2] == 'x') || (a[1, 0] == 'x' && a[1, 1] == 'x' && a[1, 2] == 'x') ||
                    (a[2, 0] == 'x' && a[2, 1] == 'x' && a[2, 2] == 'x') || (a[0, 0] == 'x' && a[1, 0] == 'x' && a[2, 0] == 'x') ||
                    (a[0, 1] == 'x' && a[1, 1] == 'x' && a[2, 1] == 'x') || (a[0, 2] == 'x' && a[1, 2] == 'x' && a[2, 2] == 'x') ||
                    (a[0, 0] == 'x' && a[1, 1] == 'x' && a[2, 2] == 'x') || (a[0, 2] == 'x' && a[1, 1] == 'x' && a[2, 0] == 'x'))
                {
                    Console.WriteLine("you win");
                    win = true;
                    break;
                }
                turn++;
                if ((turn != 9) && (!win))
                {
                    row = (int)(Utility.RandomInt(0, 2));
                    col = (int)(Utility.RandomInt(0, 2));
                    while ((a[row,col] == 'x') || (a[row,col] == 'o'))
                    {
                        row = (int)(Utility.RandomInt(0, 2));
                        col = (int)(Utility.RandomInt(0, 2));
                    }
                    a = ComputerInput(row, col, a);
                    Print(a);
                    //check winning condition for computer
                    if ((a[0, 0] == 'o' && a[0, 1] == 'o' && a[0, 2] == 'o') || (a[1, 0] == 'o' && a[1, 1] == 'o' && a[1, 2] == 'o') ||
                        (a[2, 0] == 'o' && a[2, 1] == 'o' && a[2, 2] == 'o') || (a[0, 0] == 'o' && a[1, 0] == 'o' && a[2, 0] == 'o') ||
                        (a[0, 1] == 'o' && a[1, 1] == 'o' && a[2, 1] == 'o') || (a[0, 2] == 'o' && a[1, 2] == 'o' && a[2, 2] == 'o') ||
                        (a[0, 0] == 'o' && a[1, 1] == 'o' && a[2, 2] == 'o') || (a[0, 2] == 'o' && a[1, 1] == 'o' && a[2, 0] == 'o'))
                    {
                        Console.WriteLine("computer wins");
                        win = true;
                        break;
                    }
                    turn++;
                }
            }
            //check draw condition
            if ((!win) || (turn == 9))
            {
                Console.WriteLine("draw");
            }
        }
    }
}
