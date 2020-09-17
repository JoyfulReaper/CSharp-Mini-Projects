// Gone Fishing Program
// ADAPTED FROM: STIMULATING SIMULATIONS SECOND EDTION BY C.W. ENGEL (C) 1979
// ADAPTED BY: KYLE GIVLER

using System;
class GoneFishing
{
    public static void Main()
    {
        Console.WriteLine("\nGONE FISHING\n");
        Console.WriteLine("Adapted from \"Stimulating Simulations\" (C) 1977 C. William Engel. (C) 1979 by Hayden Book");
        Console.WriteLine("Adapted from BASIC into C# by:");
        Console.WriteLine("Kyle Givler April 2020 - github.com/JoyfulReaper\n");
        Console.WriteLine("Special thanks to to following website: www.trs-80.com/wordpress/info-level-2-basic-language/");
        Console.WriteLine("\nYou are on an 8x8 lake. You can go (N)orth, (S)outh, (E)ast, (W)est, (F)ish again or (B)egin again.");
        Console.WriteLine("You must retrun to the dock before 6 hours. Fishing may be better farther out.");

        Random rand = new Random();
        decimal time = 0;

        // REM SET PROBABILITIES AND DENSITY
        double[,] probability = new double[8,8]; // The probability of catching a fish
        int[,] density = new int[8,8];     // The maximum number of fish from 1 to 5
        int pounds = 0;
        int[] playerCoords = {0,0}; // 0 = row, 1 = column

        for(int i = 0; i < 8; i++)
            for(int j = 0; j < 8; j++)
            {
                probability[i,j] = .7 * rand.NextDouble();
                density[i,j] = (int)(rand.NextDouble() * 5 + 1);
            }
        probability[0,0] = 0;

        // REM MAIN LOOP
        for(decimal i = 0; i <= 6; i += .1m)
        {
            time = i;
            if(rand.NextDouble() > probability[playerCoords[0],playerCoords[1]] || density[playerCoords[0], playerCoords[1]] < 1)
                Console.WriteLine("\nNO BITES");
            else
            {
                int numCaught = (int)(rand.NextDouble() * density[playerCoords[0],playerCoords[1]]) + 1;
                int weight = (int)(rand.NextDouble() * playerCoords[0] * playerCoords[1] + 1);
                pounds += numCaught * weight;
                Console.WriteLine($"\nYOU CAUGHT {numCaught} FISH,");
                Console.WriteLine($"EACH WEIGHING {weight} LBS.,");

            }
            Console.WriteLine("AT LOCATION {0}, {1}", playerCoords[0] + 1,playerCoords[1] + 1);
            Console.WriteLine($"TOTAL LBS. THIS TRIP IS {pounds}");

            UnexpectedExperiences(ref i, playerCoords, ref probability, ref density, ref pounds);

            Console.WriteLine($"YOU HAVE FISHED FOR {i} HOURS.");
            Console.Write("MOVE (N,S,E,W,F,B) ");
            string input = Console.ReadLine();
            char direction = Char.ToUpper(input[0]);

            switch (direction)
            {
                case 'N':
                    playerCoords[0] -= 1;
                    break;
                case 'S':
                    playerCoords[0] += 1;
                    break;
                case 'E':
                    playerCoords[1] += 1;
                    break;
                case 'W':
                    playerCoords[1] -=1;
                    break;
                case 'F':
                    // FISH!
                    break;
                case 'B':
                    Console.WriteLine("\nSTARTING OVER");
                    Main();
                    break;
            }
            if(playerCoords[0] < 0 || playerCoords[0] > 7 || 
               playerCoords[1] < 0 || playerCoords[1] > 7)
               {
                   Console.WriteLine("\nGROUNDED--SUNK");
                   GameOver(playerCoords, i, pounds);
               }

            if(playerCoords[0] == 0 && playerCoords[1] == 0)
            {
                if(i != 0m)
                    GameOver(playerCoords, i, pounds);
                Console.WriteLine("\nSTILL AT DOCK");
                Main();
            }
        }
        Console.WriteLine("\nTIME UP. THE SUN HAS SET.");
        Console.WriteLine("HALF OF YOUR CATCH HAS SPOILED.");
        pounds /= 2;
        GameOver(playerCoords, time, pounds);
    }
    public static void UnexpectedExperiences(ref decimal time, int[] playerCoords, ref double[,] probability, ref int[,] density, ref int pounds)
    {
        Random rand = new Random();
        // REM UNEXPECTED EXPERIENCES
        if(rand.NextDouble() < (double)time / 60)
        {
            Console.WriteLine("\nSTORM -- LOST 1/2 HOUR\n");
            time += .5m;
        }
        int randEvent = (int)(100 * rand.NextDouble()) + 1;
        if(randEvent < 5)
        {
            switch (randEvent)
            {
                case 1:
                    Console.WriteLine("\nFISH SCARED BY SHARK.");
                    Console.WriteLine("NOT BITING AS OFTEN.\n");
                    for(int i = 0; i < 8; i++)
                        for(int j = 0; j < 8; j++)
                            probability[i,j] -= .1;
                    break;
                case 2:
                    Console.WriteLine("\nSEA GULLS ATE SOME OF YOUR BAIT.");
                    Console.WriteLine("CATCH WILL BE SMALLER THIS TRIP.\n");
                    for(int i = 0; i < 8; i++)
                        for(int j = 0; j < 8; j++)
                            density[i,j] -= 1;
                    break;
                case 3:
                    Console.WriteLine("\nWATER SPOUT DISPLACES YOU.");
                    playerCoords[0] = rand.Next(8);
                    playerCoords[1] = rand.Next(8);
                    Console.WriteLine("YOU ARE NOW AT LOCATION {0}, {1}\n", playerCoords[0] + 1, playerCoords[1] + 1);
                    time += .2m;
                    break;
                case 4:
                    Console.WriteLine("\nYOU CAUGHT A 50 LBS. SHARK.\n");
                    pounds += 50;
                    break;
            }
        }
        return;
    }
    public static void GameOver(int[] playerCoords, decimal time, int pounds)
    {
        if(time != 0 && playerCoords[0] >= 0 && playerCoords[0] <= 7 && playerCoords[1] >=0 && playerCoords[1] <= 7)
        {
            Console.WriteLine("\nYOU ARE BACK AT THE DOCK");
            Console.WriteLine($"AFTER {time} HOURS OF FISHING.");
            Console.WriteLine($"CLEAN {pounds} LBS. OF FISH");
            Console.WriteLine($"YOU RATE {pounds/5} AS A FISHERMAN.");
        }

        Console.Write("\nANOTHER FISHING TRIP(Y,N) ");
        string input = Console.ReadLine();
        if(Char.ToUpper(input[0]) == 'Y')
            Main();
        
        System.Environment.Exit(0);
    }
}