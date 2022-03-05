using System;
using System.Linq;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            //player 1 = X and Player 2 = O

            GameBoard ticTacToe = new GameBoard();
            Console.WriteLine("Tic-Tac-Toe" + "\n***********\n");
            Console.WriteLine("Player 1 turn: ");
            ticTacToe.GenerateBoard();
            
            char userInput = char.Parse((Console.ReadLine()));
        }
    }

    public class GameBoard
    {
        char[] ticTacToeBoard = new char[9] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        Players players = new Players();

        public void GenerateBoard()
        {
            Console.WriteLine($" {ticTacToeBoard[0]} | {ticTacToeBoard[1]} | {ticTacToeBoard[2]}\n ---------\n {ticTacToeBoard[3]} | {ticTacToeBoard[4]} | {ticTacToeBoard[5]}\n ---------\n {ticTacToeBoard[6]} | {ticTacToeBoard[7]} | {ticTacToeBoard[8]}");
        }

        public void BoardMarkerPlacement(char userinput)
        {
            for (int x = 0; x < ticTacToeBoard.Length; x++)
            {
                if (userinput == ticTacToeBoard[x])
                {
                    if (players.CurrentPlayer() == 1)
                    {
                        ticTacToeBoard[x] = 'X';
                    }
                    else if (players.CurrentPlayer() == 0)
                    {
                        ticTacToeBoard[x] = 'O';
                    }
                }
               //WRITE CONDITION FOR IF USER ENTERS A NUMBER THAT IS ABOVE 9 OR BELOW 1. POSSPIBLY ADD THAT AS A METHOD FOR THE PARSE FOR USER INPUT IN THE MAIN METHOD.
            }
        }
        //WinCondition returns 1 if a player won and 0 if a player didnt.
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
            else if (ticTacToeBoard[6].Equals(ticTacToeBoard[7]) && ticTacToeBoard[7].Equals(ticTacToeBoard[8]))
            {
                return 1;
            }
            //LeftColumn
            else if (ticTacToeBoard[0].Equals(ticTacToeBoard[3]) && ticTacToeBoard[3].Equals(ticTacToeBoard[6]))
            {
                return 1;
            }
            //MiddleColumn
            else if (ticTacToeBoard[1].Equals(ticTacToeBoard[4]) && ticTacToeBoard[4].Equals(ticTacToeBoard[7]))
            {
                return 1;
            }
            //RightColumn
            else if (ticTacToeBoard[2].Equals(ticTacToeBoard[5]) && ticTacToeBoard[5].Equals(ticTacToeBoard[8]))
            {
                return 1;
            }
            //DiagnalGoingRight
            else if (ticTacToeBoard[0].Equals(ticTacToeBoard[4]) && ticTacToeBoard[4].Equals(ticTacToeBoard[8]))
            {
                return 1;
            }
            //DiagnalGoingLeft
            else if (ticTacToeBoard[2].Equals(ticTacToeBoard[4]) && ticTacToeBoard[4].Equals(ticTacToeBoard[6]))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }

    public class Players
    {
        int player = 1;

        public int CurrentPlayer()
        {
            return player;
        }
        public int NextPlayer(int player)
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
