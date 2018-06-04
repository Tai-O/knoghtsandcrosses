using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KnoghtsAndCrosses
{
    public class Game
    {
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static char[] playingarr = { '-', '-', '-', '-', '-', '-', '-', '-', '-', '-' };
        static int player = 1;
        static int choice;

        static int flag = 0;
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("To Play the game, you input the position on the board you want to move to");
                Board(arr);
                Console.WriteLine("\n");
                Console.WriteLine("Player 1:X and Player 2:O");           
                Console.WriteLine("\n");
                if (player % 2 == 0)
                {
                    Console.WriteLine("Player 2 Chance");
                }
                else
                {
                    Console.WriteLine("Player 1 Chance");
                }
                Console.WriteLine("\n");
                Board(playingarr);
                try
                {
                    choice = int.Parse(Console.ReadLine());
                } 
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                if (playingarr[choice] != 'X' && playingarr[choice] != 'O')
                {
                    if (player % 2 == 0)
                    {
                        playingarr[choice] = 'O';
                        player++;
                    }
                    else
                    {
                        playingarr[choice] = 'X';
                        player++;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry the row {0} is already marked with {1}", choice, playingarr[choice]);
                    Console.WriteLine("\n");
                    Console.WriteLine("Please wait 2 second board is loading again.....");
                    Thread.Sleep(2000);
                }
                flag = CheckWin();
            }
            while (flag != 1 && flag != -1);
            {
                Console.Clear();
                Board(playingarr);
            }
            if (flag == 1)
            {
                Console.WriteLine("Player {0} has won", (player % 2) + 1);
            }
            else  
            {
                Console.WriteLine("No Winner");
            }
            Console.ReadLine();
        }
        public static void Board(char[] array)
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", array[1], array[2], array[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", array[4], array[5], array[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", array[7], array[8], array[9]);
            Console.WriteLine("     |     |      ");
        }

        public static int CheckWin()
        {
            #region Horzontal Winning Condtion
            if (playingarr[1] == playingarr[2] && playingarr[2] == playingarr[3] &&
                playingarr[1] != '-' && playingarr[2] != '-' && playingarr[3] != '-')
            {
                return 1;
            }
            else if (playingarr[4] == playingarr[5] && playingarr[5] == playingarr[6] && 
                     playingarr[4] != '-' && playingarr[5] != '-' && playingarr[6] != '-')
            {
                return 1;
            }
            else if (playingarr[6] == playingarr[7] && playingarr[7] == playingarr[8] &&
                     playingarr[6] != '-' && playingarr[7] != '-' && playingarr[8] != '-')
            {
                return 1;
            }
            #endregion

            #region vertical Winning Condtion
            else if (playingarr[1] == playingarr[4] && playingarr[4] == playingarr[7] &&
                     playingarr[1] != '-' && playingarr[4] != '-' && playingarr[7] != '-')
            {
                return 1;
            }
            else if (playingarr[2] == playingarr[5] && playingarr[5] == playingarr[8] &&
                     playingarr[2] != '-' && playingarr[5] != '-' && playingarr[8] != '-')
            {
                return 1;
            }          
            else if (playingarr[3] == playingarr[6] && playingarr[6] == playingarr[9] &&
                     playingarr[3] != '-' && playingarr[6] != '-' && playingarr[9] != '-')
            {
                return 1;
            }
            #endregion

            #region Diagonal Winning Condition
            else if (playingarr[1] == playingarr[5] && playingarr[5] == playingarr[9] &&
                     playingarr[1] != '-' && playingarr[5] != '-' && playingarr[9] != '-')
            {
                return 1;
            }
            else if (playingarr[3] == playingarr[5] && playingarr[5] == playingarr[7] &&
                     playingarr[3] != '-' && playingarr[5] != '-' && playingarr[7] != '-')
            {
                return 1;
            }
            #endregion

            #region Checking For Draw
            else if (playingarr[1] != '-' && playingarr[2] != '-' && playingarr[3] != '-' && 
                     playingarr[4] != '-' && playingarr[5] != '-' && playingarr[6] != '-' && 
                     playingarr[7] != '-' && playingarr[8] != '-' && playingarr[9] != '-')
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
#endregion