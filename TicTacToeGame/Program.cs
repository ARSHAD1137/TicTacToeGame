using System;

namespace TicTacToeGame
{
    class Program
    {
        public static void GameDisplay()
        {
            Console.WriteLine("Select choice \n X \n O ");
            string choice = Console.ReadLine();
            switch(choice)
            {
                case "X":
                    Console.WriteLine("You choice X");
                    break;
                case "O":
                    Console.WriteLine("You choice O");
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

        }
        static void Main(string[] args)
        {
           
            Console.WriteLine("Welcome To Tic Tac Toe Game");
           
            
        }
    }
        
}
