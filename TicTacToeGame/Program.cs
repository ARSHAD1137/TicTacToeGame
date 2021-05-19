using System;

namespace TicTacToeGame
{
    class Program
    {
        static void BoardDisplay()
        {
            int boardSize = 10;
            char[] board = new char[boardSize];
            for(int i = 1; i < boardSize; i++)
            {
                board[i] = ' ';
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Tic Tac Toe Game");
            BoardDisplay();
        }
    }
        
}
