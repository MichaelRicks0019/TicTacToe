using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tic-Tac-Toe" + "\n***********\n");
            Console.WriteLine("Player 1 turn: ");
            GenerateBoard(ticTacToeBoard);
            int userInput = int.Parse((Console.ReadLine()));
        }
    }

    public class GameBoard
    {
        char[] ticTacToeBoard = new char[9] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        public void GenerateBoard()
        {
            Console.WriteLine($" {ticTacToeBoard[0]} | {ticTacToeBoard[1]} | {ticTacToeBoard[2]}\n ---------\n {ticTacToeBoard[3]} | {ticTacToeBoard[4]} | {ticTacToeBoard[5]}\n ---------\n {ticTacToeBoard[6]} | {ticTacToeBoard[7]} | {ticTacToeBoard[8]}");
        }

        public int WinCondition()
        {
            //TopRow
            if (ticTacToeBoard[0].Equals(ticTacToeBoard[1]) && ticTacToeBoard[1].Equals(ticTacToeBoard[2]))
            {
                return 1;
            }
            //MiddleRow
            else if (ticTacToeBoard[3].Equals(ticTacToeBoard[4]) && ticTacToeBoard[4].Equals(ticTacToeBoard[5]))
            {
                return 1;
            }
            //BottomRow
            else if ()
            {
                
            }
            //LeftColumn
            else if ()
            {

            }
            //MiddleColumn
            else if ()
            {

            }
            //RightColumn
            else if ()
            {

            }
            //DiagnalGoingRight
            else if ()
            {

            }
            DiagnalGoingLeft
            else if ()
            {

            }

        }
    }

    public class Players
    {
        int player = 1;
        public int NextPlayer()
        {
            if (player == 1)
            {
                return 2;
            }
            else
            {
                return 1;
            }
            
        }
    }
}
