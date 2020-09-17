// Moster Chase Program
// ADAPTED FROM: STIMULATING SIMULATIONS SECOND EDTION BY C.W. ENGEL (C) 1979
// ADAPTED BY: KYLE GIVLER

using System;
using System.Drawing;
class MonsterChase
{
    public static void Main()
    {
        // REM SET CONDITIONS
        Point monsterLoc = new Point(1,1); // X=1: Y=1
        Point yourLoc = new Point(5,5);    // R=5: C=5
        ushort turns = 10;

        for(int t = 1; t <= turns; t++)
        {
            //Console.WriteLine("You: X: {0} Y: {1}", yourLoc.X, yourLoc.Y);
            //Console.WriteLine("Mon: X: {0} Y: {1}", monsterLoc.X, monsterLoc.Y);

            DrawBoard(monsterLoc, yourLoc);

            Console.WriteLine("\n\nMOVE: {0}", t);
            Console.Write("DIRECTION: ");
            string dir = Console.ReadLine();
            char move = Char.ToUpper(dir[0]);

            switch (move)
            {
                case 'N':
                    yourLoc.X -= 1;
                    break;
                case 'E':
                    yourLoc.Y += 1;
                    break;
                case 'S':
                    yourLoc.X += 1;
                    break;
                case 'W':
                    yourLoc.Y -= 1;
                    break;
                default:
                    break;
            }
            monsterLoc = MoveMonster(monsterLoc, yourLoc);
            if(yourLoc.X * yourLoc.Y == 0 || yourLoc.X > 5 || yourLoc.Y > 5)
                GameOver("\nOUT OF BOUNDS");
            if(yourLoc.X == monsterLoc.X && yourLoc.Y == monsterLoc.Y)
                GameOver("\nEATEN");
        }
        DrawBoard(monsterLoc, yourLoc);
        GameOver("YOU SURVIVED");
    }

    public static void GameOver(string message)
    {   
        Console.WriteLine(message);

        Console.Write("PLAY AGAIN? ");
        string again = Console.ReadLine();
        if(Char.ToUpper(again[0]) == 'Y')
            Main();

        System.Environment.Exit(0);
    }

    public static Point MoveMonster(Point monster, Point player)
    {
        int dir = -99;
        Random rand = new Random();

        if(monster.X == player.X && monster.Y < player.Y)
            dir = 1;
        if(monster.X > player.X && monster.Y < player.Y)
            dir = 2;
        if(monster.X > player.X && monster.Y == player.Y)
            dir = 3;
        if(monster.X > player.X && monster.Y > player.Y)
            dir = 4;
        if(monster.X == player.X && monster.Y > player.Y)
            dir = 5;
        if(monster.X < player.X && monster.Y > player.Y)
            dir = 6;
        if(monster.X < player.X && monster.Y == player.Y)
            dir = 7;
        if(monster.X < player.X && monster.Y < player.Y)
            dir = 8;

        dir += (int)(3*rand.NextDouble()-1);

        if(dir == 0)
            dir = 8;
        if(dir == 9)
            dir = 1;
        if(dir > 1 && dir < 5)
            monster.X -= 1;
        if(dir > 5)
            monster.X += 1;
        if(dir > 3 && dir < 7)
            monster.Y -=1;
        if(dir < 3 || dir ==8)
            monster.Y +=1;

        if(monster.X == 0)
            monster.X++;
        if(monster.Y == 0)
            monster.Y++;
        if(monster.X == 6)
            monster.X--;
        if(monster.Y == 6)
            monster.Y--;

        return monster;
    }

    public static void DrawBoard(Point monsterLoc, Point yourLoc)
    {
        // REM DISPLAY GRID
        for(int i = 1; i <= 5; i++)
        {
            for(int j = 1; j <= 5; j++)
            {
                if( i == monsterLoc.X && j == monsterLoc.Y)
                {
                    Console.Write("M");
                    continue;
                }
                if( i == yourLoc.X && j == yourLoc.Y)
                {
                    Console.Write("Y");
                    continue;
                }
                Console.Write(".");
            }
            Console.WriteLine();
        }
    }
}