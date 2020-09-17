// Lost Treasure Program
// ADAPTED FROM: STIMULATING SIMULATIONS SECOND EDTION BY C.W. ENGEL (C) 1979
// ADAPTED BY: KYLE GIVLER

using System;
using System.Collections.Generic;
using System.Drawing;
public class LostTreasure
{
    public enum MovementType { Row, Column };
    public enum TerrainType { Clear, Woods, Mountains, Cave, Bluff, OakTree, Treasure };

    static TerrainType[,] locations = new TerrainType[9,9]; // DIM L(9,9) (row, column)
    static int[] playerCoords = new int[2]; // 0 = row, 1 = column
    static int numTurns = 100;
    static int sharkProb = 20; // S=.2
    static Random rand = new Random();

    private static void Setup()
    {
        Queue<int> data = new Queue<int>( new int[] {1 ,2, 2, 4, 2, 8, 3, 0, 6, 1, 7, 7,    // Decided to use a Queue to mimic BASICs READ/DATA (Maybe a different data structure is better?)
                                                     0, 1, 2, 6, 4, 1, 5, 7, 7, 2, 7, 5} ); // Re-writing this would make more sense, for now
                                                                                            // keeping closer to the original BASIC
                                                                                            // By the way, these are the R,C coords of differnt terrains. Will "fix" this mess later...

        // REM SET TERRAIN
        for(int i = 0; i < 9; i++)
            for(int j = 0; j < 9; j++)
                locations[i,j] = TerrainType.Clear;

        for(int i = 0; i < 6; i++)
            locations[data.Dequeue(), data.Dequeue()] = TerrainType.Woods;

        for(int i = 0; i < 6; i++)
            locations[data.Dequeue(), data.Dequeue()] = TerrainType.Mountains;

        locations[0,7] = TerrainType.Cave;
        locations[5,0] = TerrainType.Bluff;
        locations[8,5] = TerrainType.OakTree;
        locations[4,4] = TerrainType.Treasure;

        do {
            playerCoords[0] = rand.Next(9);
            playerCoords[1] = rand.Next(9);
        } while( Math.Sqrt( Math.Pow( (playerCoords[0] - 5), 2) + Math.Pow( (playerCoords[1] - 5), 2)) < 2);
    }

    public static void Main()
    {
        Console.WriteLine("\nLOST TREASURE\n");
        Console.WriteLine("Adapted from \"Stimulating Simulations\" (C) 1977 C. William Engel. (C) 1979 by Hayden Book");
        Console.WriteLine("Adapted from BASIC into C# by:");
        Console.WriteLine("Kyle Givler April 2020 - github.com/JoyfulReaper\n");
        Console.WriteLine("Special thanks to to following website: http://www.trs-80.com/wordpress/info-level-2-basic-language/");

        Console.WriteLine("\nYou are suddenly on an island. All you have is a map. Maybe X marks the spot?");
        Console.WriteLine("Your compass is not very accurate however, so you may veer off course.");
        Console.WriteLine("You can go (N)orth, (S)outh, (E)ast, (W)est or look at the (M)ap.");

        Setup();
        ShowMap();
        // REM START MAIN LOOP
        for(int t = 1; t <= numTurns; t++)
        {
            TerrainType terrain = locations[playerCoords[0],playerCoords[1]];
            //Console.WriteLine("DEBUG: R: {0} C: {1}", playerCoords[0] + 1, playerCoords[1] + 1);
            Console.Write("\nYOU ARE ");

            switch (terrain)
            {
                case TerrainType.Clear:
                    Console.WriteLine("IN THE CLEAR.");
                    break;
                 case TerrainType.Woods:
                    Console.WriteLine("IN THE WOODS.");
                    break;
                case TerrainType.Mountains:
                    Console.WriteLine("IN THE MOUNTAINS.");
                    break;
                case TerrainType.Cave:
                    Console.WriteLine("NEAR A CAVE.");
                    break;
                case TerrainType.Bluff:
                    Console.WriteLine("ON A BLUFF.");
                    break;
                case TerrainType.OakTree:
                    Console.WriteLine("NEAR AN OAK TREE.");
                    break;
            }

            Console.Write("MOVE (N,E,S,W,M)? ");
            string input = Console.ReadLine();
            char dir = Char.ToUpper(input[0]);
            int [] prevLoc = {playerCoords[0], playerCoords[1]}; 

            switch (dir)
            {
                case 'N':
                    playerCoords[0] -= 1;
                    MoveSubroutine(MovementType.Row);
                    break;
                case 'E':
                    playerCoords[1] += 1;
                    MoveSubroutine(MovementType.Column);
                    break;
                case 'W':
                    playerCoords[1] -= 1;
                    MoveSubroutine(MovementType.Column);
                    break;
                case 'S':
                    playerCoords[0] += 1;
                    MoveSubroutine(MovementType.Row);
                    break;
                case 'M':
                    ShowMap();
                    t--; // Looking at the Map doesn't cost a turn;
                    break;
                default:
                    Console.WriteLine("You decide to rest at your current location");
                    break;
            }
            WinOrLose(prevLoc, t);
        }
    }

    public static void MoveSubroutine(MovementType type)
    {
        // REM MOVE SUBROUTINE
        int veer = (int)(10*rand.NextDouble()+1);

        if(veer > 2)
            return;
        
        if(type == MovementType.Row)
        {
            if(veer == 1)
            {
                playerCoords[1] += 1;
                //Console.WriteLine("DEBUG: Veered: E");
            } else
            {   
                playerCoords[1] -= 1;
                //Console.WriteLine("DEBUG: Veered: W");
            }
        }

        if(type == MovementType.Column)
        {
            if(veer == 1)
            {
                playerCoords[0] -= 1;
                //Console.WriteLine("DEBUG: Veered: N");
            } else 
            {
                playerCoords[0] += 1;
                //Console.WriteLine("DEBUG: Veered: S");
            }
        }

        return;
    }

    public static void WinOrLose(int[] prevLoc, int turns)
    {
        // REM IN OCEAN, FOUND TREASURE?
        if(playerCoords[0] < 0 || playerCoords[0] > 8 ||
           playerCoords[1] < 0 || playerCoords[1] > 8  )
        {
            Console.WriteLine("\nYOU FELL INTO THE OCEAN.");
            if(rand.Next(101) < sharkProb)
            {
                Console.WriteLine("EATEN BY SHARKS!");
                GameOver();
            }
            sharkProb += 50;
            playerCoords = prevLoc;
            if(sharkProb > 100)
                sharkProb = 100;
            Console.WriteLine("THE PROBABILITY OF BEING EATEN");
            Console.WriteLine("BY A SHARK NEXT TIME IS {0}%", sharkProb);
            return;
        }

        if(locations[playerCoords[0],playerCoords[1]] == TerrainType.Treasure)
        {
            Console.WriteLine("\nYOU FOUND THE TREASURE IN {0} MOVES", turns);
            GameOver();
        }
    }

    public static void GameOver()
    {
        Console.Write("PLAY AGAIN? ");
        string again = Console.ReadLine();
        if(Char.ToUpper(again[0]) == 'Y')
            Main();
        
        System.Environment.Exit(0);
    }

    public static void ShowMap()
    {
        string map = "\nMAP:\nC M C C C C C V C\nC C W C C C C C C\nC C C C W C M C W\nW C C C C C C C C\n" +
           "C M C C(X)C C C C\nB C C C C C C M C\nC W C C C C C C C\nC C M C C M C W C\nC C C C C O C C C";
        Console.WriteLine(map);
        Console.WriteLine("C = CLEAR, M = MOUNTAIN, V = CAVE,\nB = BLUFF, W = WOODS, O = OAK TREE");
    }
}