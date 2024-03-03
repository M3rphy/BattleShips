using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    internal class Ships : Board
    {
        
        private int temporaryShipLength;
        private int x;
        private int y;
        private int z = 5;
        public void ChooseAShip()
        {

            Console.WriteLine("PICK A SHIP");
            Console.WriteLine("YOU HAVE:");
            Console.WriteLine($"[4] FOUR-MASTED SHIP IN NUMBER: {NumberOf4}");
            Console.WriteLine($"[3] THREE-MASTED SHIP IN NUMBER: {NumberOf3}");
            Console.WriteLine($"[2] TWO-MASTED SHIP IN NUMBER: {NumberOf2}");
            Console.WriteLine($"[1] ONE-MASTED SHIP IN NUMBER: {NumberOf1}");
            String x = Console.ReadLine();
            

            if (int.TryParse(x, out z))
            {
                switch (int.Parse(x))
                {

                    case 1:
                        if (NumberOf1 != 0)
                        {
                            NumberOf1 -= 1;
                            temporaryShipLength = 0;
                            PickAPlaceForShip();

                            break;
                        }
                        Console.Clear();
                        Console.WriteLine("!!!! YOU DON HAVE THIS TYPE OF SHIP ANYMORE !!!!");
                        Console.ReadKey();
                        ChooseAShip();
                        break;
                    case 2:
                        if (NumberOf2 != 0)
                        {
                            NumberOf2 -= 1;
                            temporaryShipLength = 1;
                            PickAPlaceForShip();

                            break;
                        }
                        Console.Clear();
                        Console.WriteLine("!!!! YOU DON HAVE THIS TYPE OF SHIP ANYMORE !!!!");
                        Console.ReadKey();
                        ChooseAShip();
                        break;
                    case 3:
                        if (NumberOf3 != 0)
                        {
                            NumberOf3 -= 1;
                            temporaryShipLength = 2;
                            PickAPlaceForShip();

                            break;
                        }
                        Console.Clear();
                        Console.WriteLine("!!!! YOU DON HAVE THIS TYPE OF SHIP ANYMORE !!!!");
                        Console.ReadKey();
                        ChooseAShip();
                        break;
                    case 4:
                        if (NumberOf4 != 0)
                        {
                            NumberOf4 -= 1;
                            temporaryShipLength = 3;
                            PickAPlaceForShip();

                            break;
                        }
                        Console.Clear();
                        Console.WriteLine("!!!! YOU DON HAVE THIS TYPE OF SHIP ANYMORE !!!!");
                        ChooseAShip();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("!!!! SYMBOL YOU TYPED DOESN'T FIT TO ANY OPTIONS !!!!");
                        ChooseAShip();
                        break;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("!!!! SYMBOL YOU TYPED DOESN'T FIT TO ANY OPTIONS !!!!");
                ChooseAShip();

            }
        }
        private void ShipRadiantX(int Shiplength, int x, int y)
        {
            for (int i = -1; i <= Shiplength + 1; i++)
            {
                if (x + i == -1 || x + i == 10)
                { }
                else
                {
                    if (y - 1 != -1)
                    {
                        gameField[y - 1, x + i] = ".";
                    }
                    if (y + 1 != 10)
                    {

                        gameField[y + 1, x + i] = ".";
                    }
                }
            }
            if (x - 1 != -1)
            {
                gameField[y, x - 1] = ".";
            }
            if (x + Shiplength + 1 != 10)
            {
                gameField[y, x + Shiplength + 1] = ".";
            }
        }
        private void ShipRadiantY(int Shiplength, int x, int y)
        {
            for (int i = -1; i <= Shiplength + 1; i++)
            {
                if (y + i == -1 || y + i == 10)
                { }
                else
                {
                    if (x - 1 != -1)
                    {

                        gameField[y + i, x - 1] = ".";
                    }

                    if (x + 1 != 10)
                    {

                        gameField[y + i, x + 1] = ".";
                    }
                }
            }
            if (y - 1 != -1)
            { gameField[y - 1, x] = "."; }
            if (y + Shiplength + 1 != 10)
            { gameField[y + 1 + Shiplength, x] = "."; }

        }

        int orientation = 1;
        ConsoleKey key;
        public void ShipCursor()
        {
            
            if (key == ConsoleKey.R)
            {
                orientation += 1;
                if (orientation % 2 != 0)
                {
                    for (int i = x; i <= x + temporaryShipLength; i++)
                    {
                        temporaryGameField[y, i] = " ";
                    }
                    if (y > 5)
                    {
                        for (int i = y; i <= y + temporaryShipLength; i++)
                        {
                            temporaryGameField[i - temporaryShipLength, x] = "O";
                        }
                        y -= temporaryShipLength;
                    }
                    else
                    {
                        for (int i = y; i <= y + temporaryShipLength; i++)
                        {
                            temporaryGameField[i, x] = "O";
                        }

                    }
                }
                else
                {
                    for (int i = y; i <= y + temporaryShipLength; i++)
                    {
                        temporaryGameField[i, x] = " ";
                    }
                    if (x > 5)
                    {
                        for (int i = x; i <= x + temporaryShipLength; i++)
                        {
                            temporaryGameField[y, i - temporaryShipLength] = "O";
                        }
                        x -= temporaryShipLength;
                    }
                    else
                    {
                        for (int i = x; i <= x + temporaryShipLength; i++)
                        {
                            temporaryGameField[y, i] = "O";
                        }

                    }
                }
            }
            //pozioma
            if (orientation % 2 == 0)
            {

                if (key == ConsoleKey.DownArrow && y != 9)
                {
                    for (int i = x; i <= x + temporaryShipLength; i++)
                    {
                        temporaryGameField[y, i] = " ";
                    }
                    y += 1;
                    for (int i = x; i <= x + temporaryShipLength; i++)
                    {
                        temporaryGameField[y, i] = "O";
                    }
                }
                else if (key == ConsoleKey.UpArrow && y != 0)
                {
                    for (int i = x; i <= x + temporaryShipLength; i++)
                    {
                        temporaryGameField[y, i] = " ";
                    }
                    y -= 1;
                    for (int i = x; i <= x + temporaryShipLength; i++)
                    {
                        temporaryGameField[y, i] = "O";
                    }
                }
                else if (key == ConsoleKey.RightArrow && x + temporaryShipLength != 9)
                {
                    for (int i = x; i <= x + temporaryShipLength; i++)
                    {
                        temporaryGameField[y, i] = " ";
                    }
                    x += 1;
                    for (int i = x; i <= x + temporaryShipLength; i++)
                    {
                        temporaryGameField[y, i] = "O";
                    }
                }
                else if (key == ConsoleKey.LeftArrow && x != 0)
                {
                    for (int i = x; i <= x + temporaryShipLength; i++)
                    {
                        temporaryGameField[y, i] = " ";
                    }
                    x -= 1;
                    for (int i = x; i <= x + temporaryShipLength; i++)
                    {
                        temporaryGameField[y, i] = "O";
                    }
                }
                else
                {
                    return;
                }
            }
            //Pionowo
            else
            {


                if (key == ConsoleKey.DownArrow && y + temporaryShipLength != 9)
                {
                    for (int i = y; i <= y + temporaryShipLength; i++)
                    {
                        temporaryGameField[i, x] = " ";
                    }
                    y += 1;
                    for (int i = y; i <= y + temporaryShipLength; i++)
                    {
                        temporaryGameField[i, x] = "O";
                    }
                }
                else if (key == ConsoleKey.UpArrow && y != 0)
                {
                    for (int i = y; i <= y + temporaryShipLength; i++)
                    {
                        temporaryGameField[i, x] = " ";
                    }
                    y -= 1;
                    for (int i = y; i <= y + temporaryShipLength; i++)
                    {
                        temporaryGameField[i, x] = "O";
                    }
                }
                else if (key == ConsoleKey.RightArrow && x != 9)
                {
                    for (int i = y; i <= y + temporaryShipLength; i++)
                    {
                        temporaryGameField[i, x] = " ";
                    }
                    x += 1;
                    for (int i = y; i <= y + temporaryShipLength; i++)
                    {
                        temporaryGameField[i, x] = "O";
                    }
                }
                else if (key == ConsoleKey.LeftArrow && x != 0)
                {
                    for (int i = y; i <= y + temporaryShipLength; i++)
                    {
                        temporaryGameField[i, x] = " ";
                    }
                    x -= 1;
                    for (int i = y; i <= y + temporaryShipLength; i++)
                    {
                        temporaryGameField[i, x] = "O";
                    }
                }
                else
                {
                    return;
                }
            }
        }
        public void PickAPlaceForShip()
        {
            x = 4;
            y = 4;
            Console.Clear();

            if (orientation % 2 != 0)
            {
                for (int i = y; i <= y + temporaryShipLength; i++)
                {
                    temporaryGameField[i, x] = "O";
                }
            }
            else
            {
                for (int i = x; i <= x + temporaryShipLength; i++)
                {
                    temporaryGameField[y, i] = "O";
                }
            }
            ShowGameField();
            key = Console.ReadKey().Key;
            while (key != ConsoleKey.Enter)
            {
                ShipCursor();
                Console.Clear();
                ShowGameField();
                key = Console.ReadKey().Key;
            }
            if (orientation % 2 == 0)
            {
                for (int i = x; i <= x + temporaryShipLength; i++)
                { temporaryGameField[y, i] = " "; }
                for (int i = x; i <= x + temporaryShipLength; i++)
                {

                    if (gameField[y, i] != " ")
                    {
                        Console.Clear();
                        Console.WriteLine("!!!! YOU CAN'T PLACE SHIP HERE !!!!");
                        ShowGameField();
                        Console.WriteLine("PRESS [ENTER] TO CONTINUE");
                        while (Console.ReadKey().Key != ConsoleKey.Enter)
                        { }
                        PickAPlaceForShip();
                        return;
                    }
                }
                for (int i = x; i <= x + temporaryShipLength; i++)
                {
                    gameField[y, i] = "O";
                    ShipRadiantX(temporaryShipLength, x, y);
                }
            }
            else
            {
                for (int i = y; i <= y + temporaryShipLength; i++)
                { temporaryGameField[i, x] = " "; }
                for (int i = y; i <= y + temporaryShipLength; i++)
                {
                    if (gameField[i, x] != " ")
                    {
                        Console.Clear();
                        Console.WriteLine("!!!! YOU CAN'T PLACE SHIP HERE !!!!");
                        ShowGameField();
                        Console.WriteLine("PRESS [ENTER] TO CONTINUE");
                        while (Console.ReadKey().Key != ConsoleKey.Enter)
                        { }
                        PickAPlaceForShip();
                        return;
                    }
                }
                for (int i = y; i <= y + temporaryShipLength; i++)
                {
                    gameField[i, x] = "O";
                    ShipRadiantY(temporaryShipLength, x, y);
                }
            }
            ShipsLocation[nextShip * 4] = temporaryShipLength;
            ShipsLocation[nextShip * 4 + 1] = x;
            ShipsLocation[nextShip * 4 + 2] = y;
            ShipsLocation[nextShip * 4 + 3] = orientation;
            nextShip++;
            Console.Clear();

            Console.WriteLine("**** SUCCEEDED IN PLACING SHIP ****");
            ShowGameField();
            Console.WriteLine("PRESS [ENTER] TO CONTINUE");
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            { }
            Console.Clear();

        }
        int nextShip = 0;
        public void CheckSink(Ships enemy, int[] ShipsLocation)
        {
           
            for (int g = 0; g < ShipsLocation.Length; g += 4)
            {
                int shoots = 0;
                if (enemy.ShipsLocation[g + 3] % 2 == 0)
                {
                    for (int j = 0; j < 10; j++)
                    {
                      
                        shoots = 0;
                        for (int i = enemy.ShipsLocation[g + 1]; i <= enemy.ShipsLocation[g + 1] + enemy.ShipsLocation[g]; i++)
                        {

                            if (enemyGameField[enemy.ShipsLocation[g + 2], i] == "x")
                            {
                                shoots++;
                            }
                        }
                        
                        if (shoots == enemy.ShipsLocation[g] + 1)
                        {
                            ShipEliminatedRadiantX(ShipsLocation[g], ShipsLocation[g + 1], ShipsLocation[g + 2]);
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < 10; j++)
                    {

                        shoots = 0;
                        for (int i = enemy.ShipsLocation[g + 2]; i <= enemy.ShipsLocation[g + 2] + enemy.ShipsLocation[g]; i++)
                        {
                            if (enemyGameField[i, enemy.ShipsLocation[g + 1]] == "x")
                            {
                                shoots++;
                            }
                        }
                        if (shoots == enemy.ShipsLocation[g] + 1)
                        {
                            ShipEliminatedRadiantY(ShipsLocation[g], ShipsLocation[g + 1], ShipsLocation[g + 2]);
                        }
                    }
                }
            }
        }


        private void ShipEliminatedRadiantX(int Shiplength, int x, int y)
        {
            for (int i = -1; i <= Shiplength + 1; i++)
            {
                if (x + i == -1 || x + i == 10)
                { }
                else
                {
                    if (y - 1 != -1)
                    {
                        enemyGameField[y - 1, x + i] = ".";
                    }
                    if (y + 1 != 10)
                    {

                        enemyGameField[y + 1, x + i] = ".";
                    }
                }
            }
            if (x - 1 != -1)
            {
                enemyGameField[y, x - 1] = ".";
            }
            if (x + Shiplength + 1 != 10)
            {
                enemyGameField[y, x + Shiplength + 1] = ".";
            }
        }
        private void ShipEliminatedRadiantY(int Shiplength, int x, int y)
        {
            for (int i = -1; i <= Shiplength + 1; i++)
            {
                if (y + i == -1 || y + i == 10)
                { }
                else
                {
                    if (x - 1 != -1)
                    {

                        enemyGameField[y + i, x - 1] = ".";
                    }

                    if (x + 1 != 10)
                    {

                        enemyGameField[y + i, x + 1] = ".";
                    }
                }
            }
            if (y - 1 != -1)
            { enemyGameField[y - 1, x] = "."; }
            if (y + Shiplength + 1 != 10)
            { enemyGameField[y + 1 + Shiplength, x] = "."; }

        }
        public void PickATarget(Ships enemy)
        {
            x = 4;
            y = 4;
            Console.Clear();
            temporaryEnemyGameField[y, x] = "@";
            ShowGameField();
            key = Console.ReadKey().Key;
            while (key != ConsoleKey.Enter)
            {
                Cursor();
                Console.Clear();
                ShowGameField();
                key = Console.ReadKey().Key;
            }
            if (enemyGameField[y, x] == "x" || enemyGameField[y, x] == ".")
            {
                temporaryEnemyGameField[y, x] = " ";
                Console.Clear();
                Console.WriteLine("!!!! ALREADY SHOT THIS FIELD !!!!");
                ShowGameField();
                if (!CheckWin())
                {
                    return;
                }
                Console.WriteLine("PRESS [ENTER] TO CONTINUE");
                while (Console.ReadKey().Key != ConsoleKey.Enter)
                { }
                PickATarget(enemy);
            }
            else if (enemy.gameField[y, x] == "O")
            {
                Console.Clear();
                temporaryEnemyGameField[y, x] = " ";
                enemyGameField[y, x] = "x";
                Console.WriteLine("**** NICE SHOT ****");
                CheckSink(enemy, enemy.ShipsLocation);
                ShowGameField();
                int sinkCount = 0;
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (enemyGameField[i, j] == "x")
                        {
                            sinkCount++;
                        }
                    }
                }
                if(sinkCount == 20)
                {
                    Console.WriteLine("!!!! YOU WIN !!!!");
                    Console.ReadKey();
                    return;
                }
                Console.WriteLine("PRESS [ENTER] TO CONTINUE");
                while (Console.ReadKey().Key != ConsoleKey.Enter)
                { }
                PickATarget(enemy);
            }
            else if (enemy.gameField[y, x] == " " || enemy.gameField[y, x] == ".")
            {
                Console.Clear();
                temporaryEnemyGameField[y, x] = " ";
                enemyGameField[y, x] = ".";
                Console.WriteLine("---- MISS ----");
                ShowGameField();
                Console.WriteLine("PRESS [ENTER] TO CONTINUE");
                while (Console.ReadKey().Key != ConsoleKey.Enter)
                { }

            }

        }
        public void Cursor()
        {

            temporaryEnemyGameField[y, x] = "@";
            if (key == ConsoleKey.DownArrow && y != 9)
            {
                temporaryEnemyGameField[y, x] = " ";
                y += 1;
                temporaryEnemyGameField[y, x] = "@";
            }
            else if (key == ConsoleKey.UpArrow && y != 0)
            {
                temporaryEnemyGameField[y, x] = " ";
                y -= 1;
                temporaryEnemyGameField[y, x] = "@";
            }
            else if (key == ConsoleKey.RightArrow && x != 9)
            {
                temporaryEnemyGameField[y, x] = " ";
                x += 1;
                temporaryEnemyGameField[y, x] = "@";
            }
            else if (key == ConsoleKey.LeftArrow && x != 0)
            {
                temporaryEnemyGameField[y, x] = " ";
                x -= 1;
                temporaryEnemyGameField[y, x] = "@";
            }
            else
            {
                return;
            }
        }
        //int[] table = { 3, 2, 2,1, 1, 1, 0, 0, 0, 0 };
        //Random rnd = new Random();
        //public void SetShipForAI()
        //{


        //    int AIOrientation;

        //    for (int i = 0; i < 10;i++)
        //    {
        //        AIOrientation = rnd.Next(2);
        //        if (AIOrientation%2 == 0)
        //        { SetForAIY(table[i], AIOrientation); }
        //        else
        //        { SetForAIX(table[i], AIOrientation); }


        //    }

        //}
        //public bool SetForAIX(int i, int AIOrientation)
        //{
        //    //if(AIOrientation%2 !=0)
        //    //{ return false; }
        //    int rndx = rnd.Next(0, 10);
        //    int rndy = rnd.Next(0, 10 - i);
        //    Console.WriteLine(rndx + "|" + rndy + rndy);
        //    for (int j = rndy; j <= rndy + i; j++)
        //    {
        //        if (gameField[j, rndx] == " ")
        //        {
        //            //SetForAIX(i, AIOrientation);
        //           return false;
        //       }
        //    }
        //    //for (int j = rndy; j <= rndy + i; j++)
        //    //{
        //    //    gameField[j, rndx] = "O";
        //    //    ShipRadiantY(i, rndx, rndy);
        //    //}
        //    return false;
        //}
        //public bool SetForAIY(int i, int AIOrientation)
        //{
        //    //if (AIOrientation % 2 == 0)
        //    //{ return false; }
        //    int rndx = rnd.Next(0,10 - i);
        //    int rndy = rnd.Next(0,10);
        //    Console.WriteLine(rndx+" i"+rndy);

        //    //for (int j = rndx; j <= rndx + i; j++)
        //    //{
        //    //    if (gameField[rndx, j] == " ")
        //    //    {
        //    //        SetForAIY(i, AIOrientation);
        //    //        return false;
        //    //    } 

        //    //}
        //    //for (int j = rndx; j <= rndx + i; j++)
        //    //{
        //    //    gameField[rndx, j] = "O";
        //    //    ShipRadiantX(i, rndx, rndy);
        //    //}
        //    return true;
        //}
    }
}
