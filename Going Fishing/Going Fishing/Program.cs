/*
MIT License

Copyright (c) 2020 Kyle Givler

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

using System;
using System.Diagnostics;
using System.Linq;

namespace Going_Fishing
{
    class Program
    {
        private static readonly int numberOfMoves = 60;
        private static readonly ConsoleColor defaultColor = ConsoleColor.Cyan;
        private static decimal time = 0;
        private static readonly bool debug = false;

        static void Main(string[] args)
        {
            Map map = new Map();
            Player player = new Player();
            EventProccesor proccesor = new EventProccesor(map, player);

            ShowIntro(map);

            for(int i = 0; i < numberOfMoves; i++)
            {
                if(map.GoFishing(player.PlayerX, player.PlayerY, out int caught, out int weight))
                {
                    ColorWriteLine(ConsoleColor.Yellow, $"You caught {caught} fish, each weighing {weight} pounds!\n");
                } else
                {
                    ColorWriteLine(ConsoleColor.Red, "No bites!\n");
                }

                ColorWriteLine($"You are at location {player.PlayerX}, {player.PlayerY}.");

                if (debug)
                {
                    Location loc = map.GetLocation(player.PlayerX, player.PlayerY);
                    ColorWriteLine(ConsoleColor.DarkGray, $"Probability: {loc.Probability} Densisty: {loc.Density}");
                }

                ColorWrite($"You have caught a total of ");
                ColorWrite(ConsoleColor.Yellow, player.Pounds.ToString());
                ColorWriteLine(" pounds of fish this trip.");

                if(proccesor.ProccessUnepectedEvents(ref i, out string message))
                {
                    ColorWriteLine(ConsoleColor.DarkRed, message);
                }

                time = (decimal)i / 10m;
                ColorWriteLine($"You have been fishing for {time} hours");
                ColorWriteLine("What direction would you like to move?");
                ColorWrite(ConsoleColor.DarkCyan, "(Q)uit, (N)orth, (S)outh, (E)ast, (W)est or (F)ish here again? ");
                string input = Console.ReadLine();
                Console.WriteLine();
                ProccessInput(input, player, map);
            }
            ColorWriteLine(ConsoleColor.Yellow, "Time is up! The sun has set.");
            ColorWriteLine(ConsoleColor.Yellow, "Half of your catch has spoiled!");
            player.Pounds /= 2;
            GameOver(map, player);
        }

        private static bool ProccessInput(string input, Player player, Map map)
        {
            char[] valid = { 'N', 'S', 'E', 'W', 'F', 'Q' };
            char option = char.ToUpper(input[0]);

            if (!valid.Contains<char>(option))
                return false;

            if (option == 'F')
            {
                return true;
            }
            if(option == 'Q')
            {
                System.Environment.Exit(0);
            }

            if(!player.Move(map, option))
            {
                ColorWriteLine(ConsoleColor.Red, "\nYou have grounded your boat!");
                GameOver(map, player);
            }  

            return true;
        }

        private static void GameOver(Map map, Player player)
        {
            ColorWriteLine($"\nYou are back at the dock after {time} hours of fishing");
            ColorWriteLine($"You clean {player.Pounds} Lbs. of fish.");
            ColorWriteLine($"You rate {player.Pounds / 5} as a fisherman.");

            ColorWrite("\nWould you like to play again? ");
            string input = Console.ReadLine();

            if(Char.ToUpperInvariant(input[0]) == 'Y')
            {
                Main(null);
            }
            System.Environment.Exit(0);
        }

        private static void ShowIntro(Map map)
        {
            Console.WriteLine("\nGoing Fishing\n");
            Console.WriteLine("Adapted from \"Stimulating Simulations\" (C) 1977 C. William Engel. (C) 1979 by Hayden Book");
            Console.WriteLine("Kyle Givler August 2020 - github.com/JoyfulReaper");
            Console.WriteLine($"\nYou are on an {map.MapSizeX}x{map.MapSizeY} lake. You can go (N)orth, (S)outh, (E)ast, (W)est, (F)ish again or (Q)uit");
            Console.WriteLine($"You must return to the dock within {numberOfMoves / 10} hours. Fishing may be better farther out.");
            Console.WriteLine("You begin in the southwest corner of the map (0,0)\n");
        }

        private static void ColorWrite(ConsoleColor color, string message)
        {
            ConsoleColor old = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(message);
            Console.ForegroundColor = old;
        }

        private static void ColorWrite(string message)
        {
            ColorWrite(defaultColor, message);
        }

        private static void ColorWriteLine(ConsoleColor color, string message)
        {
            ColorWrite(color, message + '\n');
        }

        private static void ColorWriteLine(string message)
        {
            ColorWriteLine(defaultColor, message);
        }
    }
}
