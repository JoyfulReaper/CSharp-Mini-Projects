/*
   My take on this: https://www.youtube.com/watch?v=WJCNxT2bolg
*/

using System;

namespace RockPaperScissors
{
    public enum Item
    {
        Invalid, Rock, Paper, Scissors
    }
    public class RockPaperScissors
    {
        private static ConsoleColor DefaultColor { get; set; } = ConsoleColor.Blue;
        public static void Main()
        {
            int playerScore = 0;
            Item playerItem = Item.Invalid;

            int computerScore = 0;
            Item computerItem;

            Random random = new Random();
            bool playerWon;

            Console.WriteLine();
            while (true)
            {
                playerWon = false;
                computerItem = (Item)random.Next(1, 4);

                Console.WriteLine($"Your Score: {playerScore} Computer score: {computerScore}");
                Console.WriteLine("(R)ock, (P)aper, (S)cissors or (Q)uit");

                bool validChoice = false;
                while (!validChoice)
                {
                    Console.Write("Make your choice: ");
                    char playerItemInput = Console.ReadLine().ToLower()[0];

                    switch (playerItemInput)
                    {
                        case 'r':
                            {
                                playerItem = Item.Rock;
                                validChoice = true;
                                if (computerItem == Item.Scissors)
                                {
                                    playerWon = true;
                                }
                                break;
                            }
                        case 'p':
                            {
                                playerItem = Item.Paper;
                                validChoice = true;
                                if (computerItem == Item.Rock)
                                {
                                    playerWon = true;
                                }
                                break;
                            }
                        case 's':
                            {
                                playerItem = Item.Scissors;
                                validChoice = true;
                                if (computerItem == Item.Paper)
                                {
                                    playerWon = true;
                                }
                                break;
                            }
                        case 'q':
                            Console.WriteLine($"\nFinal Score: Player: {playerScore} Computer {computerScore}");
                            System.Environment.Exit(0);
                            break;
                        default:
                            validChoice = false;
                            break;
                    }
                }

                Console.WriteLine();
                Console.Write("You picked: ");
                ColorWriteLine($"{Enum.GetName(typeof(Item), playerItem)}");
                Console.Write($"Computer picked: ");
                ColorWriteLine($"{Enum.GetName(typeof(Item), computerItem)}");
                if (playerWon)
                {
                    ColorWriteLine(ConsoleColor.Green, "You won!");
                    playerScore++;
                }
                else if (playerItem != computerItem)
                {
                    ColorWriteLine(ConsoleColor.Red, "You lost!");
                    computerScore++;
                }
                else
                {
                    ColorWriteLine(ConsoleColor.Yellow, "Tie!");
                }

                Console.WriteLine();
            }

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
            ColorWrite(DefaultColor, message);
        }

        private static void ColorWriteLine(ConsoleColor color, string message)
        {
            ColorWrite(color, message + '\n');
        }

        private static void ColorWriteLine(string message)
        {
            ColorWriteLine(DefaultColor, message);
        }
    }
}