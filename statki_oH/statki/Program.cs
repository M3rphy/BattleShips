using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleShip;

namespace BattleShip
{
    internal class Program
    {
        static void Main()
        {
            Ships game = new Ships();
            string choice = "";
            bool makeChoice = true;
            int playerOneWins = 0;
            int playerTwoWins = 0;
            bool keepPlaying = true;
            while (makeChoice)
            {
                game.ShowGamesMode();
                choice = Console.ReadLine();
                if (choice == "1" || choice == "2")
                {
                    makeChoice = false;
                }
            }
            if (choice == "1")
            {
                while (keepPlaying)
                {
                    Ships PlayerOne = new Ships();
                    Ships PlayerTwo = new Ships();
                    Console.Clear();
                    PlayerOne.SetName(1);
                    PlayerTwo.SetName(2);
                    Console.Clear();
                    
                    Console.Write("!!!! ");
                    Console.ForegroundColor
                                 = ConsoleColor.Cyan;
                    Console.Write($"[{PlayerOne.name}]");
                    Console.ForegroundColor
                                 = ConsoleColor.White;
                    Console.Write($" TURN TO PLACE SHIPS !!!!\n" +
                    "Press [Enter] to continue");
                    while (Console.ReadKey().Key != ConsoleKey.Enter) { };
                    Console.Clear();
                    for (int i = 0; i < 10; i++)
                    {
                        PlayerOne.ChooseAShip();
                    }
                    Console.Write("!!!! ");
                    Console.ForegroundColor
                                 = ConsoleColor.Cyan;
                    Console.Write($"[{PlayerTwo.name}]");
                    Console.ForegroundColor
                                 = ConsoleColor.White;
                    Console.Write($" TURN TO PLACE SHIPS !!!!\n" +
                    "Press [Enter] to continue");
                    while (Console.ReadKey().Key != ConsoleKey.Enter) { };
                    Console.Clear();
                    for (int i = 0; i < 10; i++)
                    {
                        PlayerTwo.ChooseAShip();
                    }

                    int playerTurn = 0;
                    while (PlayerOne.CheckWin() && PlayerTwo.CheckWin())
                    {
                        Console.Clear() ;
                        if (playerTurn % 2 == 0)
                        {
                            Console.Write($"!!!! TURN TO SHOOT FOR ");
                            Console.ForegroundColor
                                         = ConsoleColor.Cyan;
                            Console.Write($"[{PlayerOne.name}]");
                            Console.ForegroundColor
                                         = ConsoleColor.White;
                            Console.WriteLine("!!!!\n" +
                                "Press [Enter] to continue");
                            while (Console.ReadKey().Key != ConsoleKey.Enter) { };
                            PlayerOne.PickATarget(PlayerTwo);


                        }
                        else
                        {
                            Console.Write($"!!!! TURN TO SHOOT FOR ");
                            Console.ForegroundColor
                                         = ConsoleColor.Cyan;
                            Console.Write($"[{PlayerTwo.name}]");
                            Console.ForegroundColor
                                         = ConsoleColor.White;
                            Console.WriteLine("!!!!\n" +
                                "Press [Enter] to continue");
                            while (Console.ReadKey().Key != ConsoleKey.Enter) { };
                            PlayerTwo.PickATarget(PlayerOne);
                        }
                        playerTurn++;
                    }
                    Console.Clear();
                    if (!PlayerOne.CheckWin())
                    {
                        playerOneWins++;
                    }
                    else if (!PlayerTwo.CheckWin())
                    {
                        playerTwoWins++;
                    }

                    
                    makeChoice = true;
                    while (makeChoice)
                    {
                        Console.WriteLine($"{PlayerOne.name}: {playerOneWins} | {PlayerTwo.name}: {playerTwoWins}");
                        Console.WriteLine("DO YOU WANT TO PLAY AGAIN??");
                        Console.WriteLine("[1]YES   [2]NO");
                        choice = Console.ReadLine();
                        if (choice == "1" || choice == "2")
                        {
                            makeChoice = false;
                        }
                        else
                        {
                            Console.Clear() ;
                        }
                    }
                    if (choice == "1")
                    {
                        keepPlaying = true;
                    }
                    else if (choice == "2")
                    {
                        keepPlaying = false;
                    }
                }


            }
            else if (choice == "2")
            {
                Console.WriteLine
                   ("+===========================================+\n" +
                    "|                                           |\n" +
                    "|       O = Pole w którym znajduje sie      |\n" +
                    "|           statek                          |\n" +
                    "|       . = Miejsce w któym nie można       |\n" +
                    "|           postawić statku/ Miejsce        |\n" +
                    "|           jest już zatopione              |\n" +
                    "|      @ = Celownik                         |\n" +
                    "|                                           |\n" +
                    "|    Faza stawiania statków                 |\n" +
                    "|    1) wybierasz za pomocą wpisania        |\n" +
                    "|       z klawiatury odpowiedniego numer    |\n" +
                    "|       zgodnie z instrukcją                |\n" +
                    "|    2) wyświetla ci sie zasięg twojego     |\n" +
                    "|       statku który można przesuwać        |\n" +
                    "|       STRAŁKAMI i obracać R               |\n" +
                    "|    3) by postawić statek w wyznaczonym    |\n" +
                    "|       miejscu kliknij ENTER               |\n" +
                    "|                                           |\n" +
                    "|    Faza strzelania                        |\n" +
                    "|    1) Pojawia sie na środku celownik      |\n" +
                    "|       oznaczony @                         |\n" +
                    "|    2) możesz przesuewać celiwnik          |\n" +
                    "|       STRZAŁKI                            |\n" +
                    "|    3) Możesz wystrzelić w wskazane        |\n" +
                    "|       miejsce za pomocą przycisku         |\n" +
                    "|       ENTER                               |\n" +
                    "|                                           |\n" +
                    "+===========================================+");
                Console.WriteLine("Press [Enter] to continue");
                while (Console.ReadKey().Key != ConsoleKey.Enter) { };
                Main();
            }    
        }
    }
}
