using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    internal class Player
    {
        public int NumberOf1 = 4;
        public int NumberOf2 = 3;
        public int NumberOf3 = 2;
        public int NumberOf4 = 1;
        public bool Win = true;
        public string name;
        public int[] ShipsLocation = new int[40];
        public void SetName(int whichPlayer)
        {
            Console.WriteLine($"SET NAME FOR {whichPlayer} PLAYER:");
            name = Console.ReadLine();     
        }
        public void ShowGamesMode()
        {
            Console.Clear();
            Console.WriteLine
               ("+===============================================+\n" +
                "|                                               |\n" +
                "|             **** BattleShip ***               |\n" +
                "|                                               |\n" +
                "|             [1] PLAY                          |\n" +
                "|             [2] HOW TO PLAY                   |\n" +
                "|                                               |\n" +
                "+===============================================+");
        }
    }
}
