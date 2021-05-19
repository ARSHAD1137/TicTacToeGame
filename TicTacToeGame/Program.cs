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
        static void SelectLetter()
        {
            Console.WriteLine("Select The Letter Between 'X or 'O");
            string userLetter = Console.ReadLine();
           
            if (userLetter.Equals("X") || userLetter.Equals("x"))
            {
                Console.WriteLine("You Choose 'X'");
                string computerLetter = "O";
            }
            else if (userLetter.Equals("O") || userLetter.Equals("o"))
            {
                Console.WriteLine("You Choose 'O'");
                string computerLetter = "X";
            }
            else
            {
                Console.WriteLine("Invalid Letter");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Tic Tac Toe Game");
            BoardDisplay();
            SelectLetter();
        }
    }
        
}
