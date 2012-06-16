using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/* 0, 1, 2
 * 3, 4, 5
 * 6, 7, 8
*/
namespace ConsoleApplication1
{
    public class Board
    {
        private string[] board = new string[9];
        private string winner = "";
        private string player1 = "";
        private string player2 = "";
        int counter = 1;
        int turncounter = 0;
        string instructions = "TL | T | TR\n" + "----------\n" + "L  | C |  R\n" + "----------\n" + "BL | B | BR\n";

        public int TurnCounter
        {
            get
            {
                return turncounter;
            }
            set
            {
                turncounter = value;
            }
        }

        public string Winner
        {
            get
            {
                return winner;
            }
            set
            {
                winner = value;
            }
        }

        public string Player1
        {
            get
            {
                return player1;
            }
            set
            {
                player1 = value;
            }
        }

        public string Player2
        {
            get
            {
                return player2;
            }
            set
            {
                player2 = value;
            }
        }

        public string TOPLEFT
        {
            get
            {
                return board[0];
            }
            set
            {
                board[0] = value;
            }
        }

        public string TOP
        {
            get
            {
                return board[1];
            }
            set
            {
                board[1] = value;
            }
        }

        public string TOPRIGHT
        {
            get
            {
                return board[2];
            }
            set
            {
                board[2] = value;
            }
        }

        public string LEFT
        {
            get
            {
                return board[3];
            }
            set
            {
                board[3] = value;
            }
        }

        public string CENTER
        {
            get
            {
                return board[4];
            }
            set
            {
                board[4] = value;
            }
        }

        public string RIGHT
        {
            get
            {
                return board[5];
            }
            set
            {
                board[5] = value;
            }
        }

        public string BOTTOMLEFT
        {
            get
            {
                return board[6];
            }
            set
            {
                board[6] = value;
            }
        }

        public string BOTTOM
        {
            get
            {
                return board[7];
            }
            set
            {
                board[7] = value;
            }
        }

        public string BOTTOMRIGHT
        {
            get
            {
                return board[8];
            }
            set
            {
                board[8] = value;
            }
        }

/* 0, 1, 2
 * 3, 4, 5
 * 6, 7, 8
*/

        public void InitializeBoard()
        {
            for (int i = 0; i < 9; i++)
            {
                board[i] = " ";
            }
        }

        public void printBoard()
        {
            Console.WriteLine("\n" + board[0] + " | " + board[1] + " | " + board[2]);
            Console.WriteLine("----------");
            Console.WriteLine(board[3] + " | " + board[4] + " | " + board[5]);
            Console.WriteLine("----------");
            Console.WriteLine(board[6] + " | " + board[7] + " | " + board[8]);
            Console.WriteLine("\n" + instructions + "\n");
        }

        public void resetBoard()
        {
            InitializeBoard();
            counter = 1;
            turncounter = 0;
            winner = "";
        }

        public void playGame()
        {
            while (this.CheckForWin() == "n0n3")
            {
                this.PlayerTurn();
                if (this.TurnCounter == 9 && this.CheckForWin() == "n0n3")
                {
                    this.printBoard();
                    Console.WriteLine("\nIt's a tie!\nTo play again, press 'p'.\nPress any other key to exit.");
                    break;
                }
            }
            if (this.TurnCounter != 9 || this.CheckForWin() != "n0n3")
            {
                this.printBoard();
                Console.WriteLine("\n" + this.Winner + " is the winner! Congratulations! To play again, enter 'p'.\nEnter any other key to exit.");
            }
            char end = (char)Console.Read();
            if (end == 'p')
            {
                // newgame
                this.resetBoard();
                this.playGame();
            }
        }

        public void PlayerTurn()
        {
            printBoard();
            turncounter++;
            if (counter == 1)
            {
                counter = 2;
                Console.WriteLine(player1 + ", it is your turn.\n");
                string move = Console.ReadLine();
                placeMove(move);
            }
            else
            {
                counter = 1;
                Console.WriteLine(player2 + ", it is your turn.");
                string move = Console.ReadLine();
                placeMove(move);
            }
        }

        public void placeMove(string position)
        {
            if(position == "TL")
            {
                if (TOPLEFT == " ")
                {
                    if (counter == 2)
                    {
                        TOPLEFT = "X";
                        return;
                    }
                    TOPLEFT = "O";
                }
                else
                {
                    takentryagain(position);
                }
            }
            else if(position == "T")
            {
                if (TOP == " ")
                {
                    if (counter == 2)
                    {
                        TOP = "X";
                        return;
                    }
                    TOP = "O";
                }
                else
                {
                    takentryagain(position);
                }
            }
            else if (position == "TR")
            {
                if (TOPRIGHT == " ")
                {
                    if (counter == 2)
                    {
                        TOPRIGHT = "X";
                        return;
                    }
                    TOPRIGHT = "O";
                }
                else
                {
                    takentryagain(position);
                }
            }
            else if (position == "L")
            {
                if (LEFT == " ")
                {
                    if (counter == 2)
                    {
                        LEFT = "X";
                        return;
                    }
                    LEFT = "O";
                }
                else
                {
                    takentryagain(position);
                }
            }
            else if (position == "C")
            {
                if (CENTER == " ")
                {
                    if (counter == 2)
                    {
                        CENTER = "X";
                        return;
                    }
                    CENTER = "O";
                }
                else
                {
                    takentryagain(position);
                }
            }
            else if (position == "R")
            {
                if (RIGHT == " ")
                {
                    if (counter == 2)
                    {
                        RIGHT = "X";
                        return;
                    }
                    RIGHT = "O";
                }
                else
                {
                    takentryagain(position);
                }
            }
            else if (position == "BL")
            {
                if (BOTTOMLEFT == " ")
                {
                    if (counter == 2)
                    {
                        BOTTOMLEFT = "X";
                        return;
                    }
                    BOTTOMLEFT = "O";
                }
                else
                {
                    takentryagain(position);
                }
            }
            else if (position == "B")
            {
                if (BOTTOM == " ")
                {
                    if (counter == 2)
                    {
                        BOTTOM = "X";
                        return;
                    }
                    BOTTOM = "O";
                }
                else
                {
                    takentryagain(position);
                }
            }
            else if (position == "BR")
            {
                if (BOTTOMRIGHT == " ")
                {
                    if (counter == 2)
                    {
                        BOTTOMRIGHT = "X";
                        return;
                    }
                    BOTTOMRIGHT = "O";
                }
                else
                {
                    takentryagain(position);
                }
            }
            else
            {
                tryagain();
            }
        }

        public void tryagain()
        {
            if (counter == 1)
            {
                counter = 2;
            }
            else
            {
                counter = 1;
            }
            Console.WriteLine("\nInvalid move, make a valid move in the instructions given.\n");
        }

        public void takentryagain(string position)
        {
            if (counter == 1)
            {
                counter = 2;
            }
            else
            {
                counter = 1;
            }
            Console.WriteLine("\nInvalid move, the position: " + position + " is already taken.\n");
        }

        public string CheckForWin()
        {
            if (checkDiagonal() == true || checkHorizontal() == true || checkVertical() == true)
            {
                return winner;
            }
            return "n0n3";
        }

        public bool checkHorizontal()
        {
            if (TOPLEFT == TOP && TOP == TOPRIGHT && TOP != " ")
            {
                if (TOP == "X")
                {
                    winner = player1;
                }
                else
                {
                    winner = player2;
                }
                return true;
            }
            if (LEFT == CENTER && CENTER == RIGHT && CENTER != " ")
            {
                if (CENTER == "X")
                {
                    winner = player1;
                }
                else
                {
                    winner = player2;
                }
                return true;
            }
            if (BOTTOMLEFT == BOTTOM && BOTTOM == BOTTOMRIGHT && BOTTOM != " ")
            {
                if (BOTTOM == "X")
                {
                    winner = player1;
                }
                else
                {
                    winner = player2;
                }
                return true;
            }
            return false;
        }

        public bool checkVertical()
        {
            if (TOPLEFT == LEFT && LEFT == BOTTOMLEFT && LEFT != " ")
            {
                if (LEFT == "X")
                {
                    winner = player1;
                }
                else
                {
                    winner = player2;
                }
                return true;
            }
            if (TOP == CENTER && CENTER == BOTTOM && CENTER != " ")
            {
                if (LEFT == "X")
                {
                    winner = player1;
                }
                else
                {
                    winner = player2;
                }
                return true;
            }
            if (TOPRIGHT == RIGHT && RIGHT == BOTTOMRIGHT && RIGHT != " ")
            {
                if (RIGHT == "X")
                {
                    winner = player1;
                }
                else
                {
                    winner = player2;
                }
                return true;
            }
            return false;
        }

        public bool checkDiagonal()
        {
            if ((TOPLEFT == CENTER && CENTER == BOTTOMRIGHT) && TOPLEFT != " ")
            {
                if (TOPLEFT == "X")
                {
                    winner = player1;
                }
                else
                {
                    winner = player2;
                }
                return true;
            }
            if ((TOPRIGHT == CENTER && CENTER == BOTTOMLEFT) && TOPRIGHT != " ")
            {
                if (TOPRIGHT == "X")
                {
                    winner = player1;
                }
                else
                {
                    winner = player2;
                }
                return true;
            }
            return false;
        }
    }
}
