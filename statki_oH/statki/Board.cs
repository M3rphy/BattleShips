using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BattleShip
{
    internal class Board : Player
    {
        public String[,] gameField = {
            {" ", " ", " ", " ", " ", " ", " ", " ", " ", " " },
            {" ", " ", " ", " ", " ", " ", " ", " ", " ", " " },
            {" ", " ", " ", " ", " ", " ", " ", " ", " ", " " },
            {" ", " ", " ", " ", " ", " ", " ", " ", " ", " " },
            {" ", " ", " ", " ", " ", " ", " ", " ", " ", " " },
            {" ", " ", " ", " ", " ", " ", " ", " ", " ", " " },
            {" ", " ", " ", " ", " ", " ", " ", " ", " ", " " },
            {" ", " ", " ", " ", " ", " ", " ", " ", " ", " " },
            {" ", " ", " ", " ", " ", " ", " ", " ", " ", " " },
            {" ", " ", " ", " ", " ", " ", " ", " ", " ", " " }
        };
        public String[,] temporaryGameField = {
            {" ", " ", " ", " ", " ", " ", " ", " ", " ", " " },
            {" ", " ", " ", " ", " ", " ", " ", " ", " ", " " },
            {" ", " ", " ", " ", " ", " ", " ", " ", " ", " " },
            {" ", " ", " ", " ", " ", " ", " ", " ", " ", " " },
            {" ", " ", " ", " ", " ", " ", " ", " ", " ", " " },
            {" ", " ", " ", " ", " ", " ", " ", " ", " ", " " },
            {" ", " ", " ", " ", " ", " ", " ", " ", " ", " " },
            {" ", " ", " ", " ", " ", " ", " ", " ", " ", " " },
            {" ", " ", " ", " ", " ", " ", " ", " ", " ", " " },
            {" ", " ", " ", " ", " ", " ", " ", " ", " ", " " }
        };
        public String[,] enemyGameField = {
            {" ", " ", " ", " ", " ", " ", " ", " ", " ", " " },
            {" ", " ", " ", " ", " ", " ", " ", " ", " ", " " },
            {" ", " ", " ", " ", " ", " ", " ", " ", " ", " " },
            {" ", " ", " ", " ", " ", " ", " ", " ", " ", " " },
            {" ", " ", " ", " ", " ", " ", " ", " ", " ", " " },
            {" ", " ", " ", " ", " ", " ", " ", " ", " ", " " },
            {" ", " ", " ", " ", " ", " ", " ", " ", " ", " " },
            {" ", " ", " ", " ", " ", " ", " ", " ", " ", " " },
            {" ", " ", " ", " ", " ", " ", " ", " ", " ", " " },
            {" ", " ", " ", " ", " ", " ", " ", " ", " ", " " }
        };
        public String[,] temporaryEnemyGameField = {
            {" ", " ", " ", " ", " ", " ", " ", " ", " ", " " },
            {" ", " ", " ", " ", " ", " ", " ", " ", " ", " " },
            {" ", " ", " ", " ", " ", " ", " ", " ", " ", " " },
            {" ", " ", " ", " ", " ", " ", " ", " ", " ", " " },
            {" ", " ", " ", " ", " ", " ", " ", " ", " ", " " },
            {" ", " ", " ", " ", " ", " ", " ", " ", " ", " " },
            {" ", " ", " ", " ", " ", " ", " ", " ", " ", " " },
            {" ", " ", " ", " ", " ", " ", " ", " ", " ", " " },
            {" ", " ", " ", " ", " ", " ", " ", " ", " ", " " },
            {" ", " ", " ", " ", " ", " ", " ", " ", " ", " " }
        };


        public void ShowGameField()
        { Console.ForegroundColor
                             = ConsoleColor.White;
            Console.WriteLine($"               |      {name}      |                                                 |        ENEMY      |");
            Console.WriteLine("   | A | B | C | D | E | F | G | H | I | J |                         | A | B | C | D | E | F | G | H | I | J |");

            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine("---+---+---+---+---+---+---+---+---+---+---+                      ---+---+---+---+---+---+---+---+---+---+---+");
                if (i < 9)
                {
                    Console.Write($" {i + 1} |");
                }
                else
                {
                    Console.Write($"{i + 1} |");
                }
                for (int j = 0; j < 10; j++)
                {
                    if (temporaryGameField[i, j] == "O")
                    {
                        Console.ForegroundColor
                             = ConsoleColor.Red;
                        Console.Write($" {temporaryGameField[i, j]}");
                        Console.ForegroundColor
                             = ConsoleColor.White;
                        Console.Write(" |");
                    }
                    else
                    {
                        Console.Write($" {gameField[i, j]} |");
                    }
                }
                Console.Write("                      ");
                if (i < 9)
                {
                    Console.Write($" {i + 1} |");
                }
                else
                {
                    Console.Write($"{i + 1} |");
                }
                for (int j = 0; j < 10; j++)
                {
                    if (temporaryEnemyGameField[i, j] == "@")
                    {
                        Console.Write($" {temporaryEnemyGameField[i, j]} |");
                    }
                    else
                    {
                        Console.Write($" {enemyGameField[i, j]} |");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("---+---+---+---+---+---+---+---+---+---+---+                      ---+---+---+---+---+---+---+---+---+---+---+");
        }
        public Boolean CheckWin()
        {
            int sinkCount = 0;
            for(int i = 0; i < 10; i++) 
            {
                for(int j = 0; j < 10; j++)
                {
                    if (enemyGameField[i, j] == "x")
                    {
                        sinkCount++;
                    }
                }
            }
            if(sinkCount == 20)
            {
                return false;
            }
            return true;
        }
    }
}
