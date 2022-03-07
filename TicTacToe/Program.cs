using System;
using System.Linq;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            //player 1 = X and Player 2 = O
            TicTacToe.PlayTicTacToe();
        }
    }

    public class GameBoard
    {
        //TicTacToe board with KeyPad layout:
        char[] ticTacToeBoard = new char[9] { '7', '8', '9', '4', '5', '6', '1', '2', '3' };
        int player = 1;
        private bool tieCondition = false;
        private bool winCondition = false;

        public void GenerateBoard()
        {
            Console.WriteLine($" {ticTacToeBoard[0]} | {ticTacToeBoard[1]} | {ticTacToeBoard[2]}\n ---------\n {ticTacToeBoard[3]} | {ticTacToeBoard[4]} | {ticTacToeBoard[5]}\n ---------\n {ticTacToeBoard[6]} | {ticTacToeBoard[7]} | {ticTacToeBoard[8]}");
        }

        //Places the correct marker on the board depending on which players turn it is. X for player 1 and O for player 2.
        public void BoardMarkerPlacement(char userinput)
        {
            for (int x = 0; x < ticTacToeBoard.Length; x++)
            {
                if (userinput == ticTacToeBoard[x])
                {
                    if (player == 1 && ticTacToeBoard[x] != 'X' && ticTacToeBoard[x] != 'O')
                    {
                        ticTacToeBoard[x] = 'X';
                        NextPlayer();
                        break;
                    }
                    else if (player == 2 && ticTacToeBoard[x] != 'X' && ticTacToeBoard[x] != 'O')
                    {
                        ticTacToeBoard[x] = 'O';
                        NextPlayer();
                        break;
                    }
                }
                else
                {

                }
            }
        }
        //WinCondition returns 1 if a player won and 0 if a player didnt.
        public bool WinCondition()
        {
            //TopRow
            if (ticTacToeBoard[0].Equals(ticTacToeBoard[1]) && ticTacToeBoard[1].Equals(ticTacToeBoard[2]))
            {
                winCondition = true;
                return winCondition;
            }
            //MiddleRow
            else if (ticTacToeBoard[3].Equals(ticTacToeBoard[4]) && ticTacToeBoard[4].Equals(ticTacToeBoard[5]))
            {
                winCondition = true;
                return winCondition;
            }
            //BottomRow
            else if (ticTacToeBoard[6].Equals(ticTacToeBoard[7]) && ticTacToeBoard[7].Equals(ticTacToeBoard[8]))
            {
                winCondition = true;
                return winCondition;
            }
            //LeftColumn
            else if (ticTacToeBoard[0].Equals(ticTacToeBoard[3]) && ticTacToeBoard[3].Equals(ticTacToeBoard[6]))
            {
                winCondition = true;
                return winCondition;
            }
            //MiddleColumn
            else if (ticTacToeBoard[1].Equals(ticTacToeBoard[4]) && ticTacToeBoard[4].Equals(ticTacToeBoard[7]))
            {
                winCondition = true;
                return winCondition;
            }
            //RightColumn
            else if (ticTacToeBoard[2].Equals(ticTacToeBoard[5]) && ticTacToeBoard[5].Equals(ticTacToeBoard[8]))
            {
                winCondition = true;
                return winCondition;
            }
            //DiagnalGoingRight
            else if (ticTacToeBoard[0].Equals(ticTacToeBoard[4]) && ticTacToeBoard[4].Equals(ticTacToeBoard[8]))
            {
                winCondition = true;
                return winCondition;
            }
            //DiagnalGoingLeft
            else if (ticTacToeBoard[2].Equals(ticTacToeBoard[4]) && ticTacToeBoard[4].Equals(ticTacToeBoard[6]))
            {
                winCondition = true;
                return winCondition;
            }
            else
            {
                return winCondition;
            }

        }
        //Get methods for WinCondition and TieCondition. Use to verify if game is won or tied
        public bool GetWinCondition()
        {
            return winCondition;
        }
        public bool GetTieCondition()
        {
            return tieCondition;
        }

        //PLAYERS METHODS
        public bool TieCondition()
        {
            for (int x = 0; x < ticTacToeBoard.Length; x++)
            {
                if (ticTacToeBoard[x] != 'X' && ticTacToeBoard[x] != 'O')
                {
                    return tieCondition = false;
                }
                else
                {

                }
                    
            }
            tieCondition = true;
            return tieCondition;
            
        }
        public int CurrentPlayer()
        {
            return player;
        }
        public void NextPlayer()
        {
            if (player == 1)
            {
                player = 2;
            }
            else if (player == 2)
            {
                player = 1;
            }
        }

        public void ReplayMessage()
        {
            string replay;
            Console.WriteLine("Type yes to play again and no to quit: ");
                do
            {
                replay = Console.ReadLine();
                if (replay != "yes" && replay != "no")
                {
                    Console.WriteLine("Type yes to replay and no to quit");
                }
            } while (replay != "yes" && replay != "no");
            if (replay == "yes")
            {
                Console.Clear();
                TicTacToe.PlayTicTacToe();
            }
            else if (replay == "no")
            {
                Console.Clear();
                Console.WriteLine("Thanks for playing TicTacToe!");
            }
            Console.ReadKey();
        }

}



    public static class TicTacToe
    {
        //User Commands
        public static void PlayTicTacToe()
        {
            GameBoard ticTacToe = new GameBoard();
            char userInput = '\0';
            do
            {
                Console.WriteLine("Tic-Tac-Toe\n***********\nPlayer 1 (X)\nPlayer 2 (O)\n\n");
                Console.WriteLine($"Player {ticTacToe.CurrentPlayer()}'s Turn:");
                ticTacToe.GenerateBoard();
                try
                {
                    userInput = char.Parse((Console.ReadLine()));
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Invalid value entered" + ex.Message);
                }
                ticTacToe.BoardMarkerPlacement(userInput);
                Console.Clear();
                if (ticTacToe.TieCondition() == true)
                {
                    break;
                }
            } while (ticTacToe.WinCondition() == false);

            if (ticTacToe.GetWinCondition() == true)
            {
                ticTacToe.NextPlayer();
                ticTacToe.GenerateBoard();
                Console.WriteLine($"Congrats Player {ticTacToe.CurrentPlayer()}\n YOU WON\n\nPress any key for a victory beep!");
                Console.ReadKey();
                Console.Beep();
                ticTacToe.ReplayMessage();
            }
            else if (ticTacToe.GetTieCondition() == true)
            {
                ticTacToe.GenerateBoard();
                Console.WriteLine("Game Ended in a tie");
                ticTacToe.ReplayMessage();
            }
            
        }
    }

    /*
     * 
     * I tried having another class of players be auto implimented into GameBoard but couldnt figure it out
     * 
    public class Players
    {
        int player = 1;

        public int CurrentPlayer()
        {
            return player;
        }
        public void NextPlayer()
        {
            if (player == 1)
            {
                player = 2;
            }
            else
            {
                player = 1;
            }
            
        }
    } */
}
