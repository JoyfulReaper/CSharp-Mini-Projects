/*
MIT License

Copyright(c) 2021 Kyle Givler
https://github.com/JoyfulReaper

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

using RockPaperScissors.Enums;
using RockPaperScissors.Helpers;
using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRounds;
            int playerScore = 0;
            int computerScore = 0;

            ShowIntro();

            Console.Write("How many rounds would you like to play (1-100): ");
            if(!InputIsValid(Console.ReadLine(), 1, 100, out int rounds))
            {
                Console.WriteLine("Please enter a valid number of rounds!");
                Console.WriteLine();
                Main(null);
            }

            numberOfRounds = rounds;

            RockPaperScissors rockPaperScissors = new RockPaperScissors();

            for(int i = 0; i < numberOfRounds; i++)
            {
                ShowRoundInfo(playerScore, computerScore, i + 1, numberOfRounds);
                PlayRound(rockPaperScissors, ref playerScore, ref computerScore);
            }

            ShowResults(playerScore, computerScore);
        }

        private static void ShowRoundInfo(int playerScore, int computerScore, int round, int numberOfRounds)
        {
            Console.WriteLine();
            Console.WriteLine($"Round #{round}, of {numberOfRounds}");
            Console.WriteLine($"Player Score: {playerScore} Computer Score {computerScore}");
            Console.WriteLine();
        }

        private static void ShowResults(int playerScore, int computerScore)
        {
            Console.WriteLine();
            Console.WriteLine("Game over!");

            if(playerScore > computerScore)
            {
                Console.WriteLine("You beat the computer!");
            }
            else if(computerScore > playerScore)
            {
                Console.WriteLine("Oh no! The computer won!");
            }
            else
            {
                Console.WriteLine("Its a tie!");
            }

            Console.WriteLine($"Computer Score: {computerScore} Your Score: {playerScore}");

            Console.WriteLine();
            Console.Write("Play again? y/N: ");
            var again = Console.ReadLine();
            if(Char.ToLower(again[0]) == 'y')
            {
                Console.WriteLine();
                Main(null);
            }

            Environment.Exit(0);
        }

        private static void PlayRound(RockPaperScissors rockPaperScissors, ref int playerScore, ref int computerScore)
        {
            ThrowResult computerThrow = rockPaperScissors.GetComputerThrow();
            ThrowResult playerThrow = GetPlayerThrow();

            Winner winner = rockPaperScissors.DetermineWinner(playerThrow, computerThrow);

            Console.WriteLine($"You threw: {Enum.GetName(playerThrow)}");
            Console.WriteLine($"The computer threw: {Enum.GetName(computerThrow)}");

            if (winner == Winner.Player1)
            {
                Console.WriteLine("You win this round!");
                playerScore++;
            }
            else if (winner == Winner.Player2)
            {
                Console.WriteLine("The computer won this round!");
                computerScore++;
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }
        }

        private static ThrowResult GetPlayerThrow()
        {
            ThrowResult output = (ThrowResult)(-1);
            bool valid = false;

            while(!valid)
            {
                Console.WriteLine("Choose throw: ");
                Console.WriteLine("1) Rock");
                Console.WriteLine("2) Paper");
                Console.WriteLine("3) Scissors");
                Console.Write("Input choice: ");

                if( InputIsValid(Console.ReadLine(), 1, 3, out int throwChoice) )
                {
                    output = (ThrowResult)throwChoice - 1;
                    if(!EnumHelper.EnumValueIsValid(output))
                    {
                        throw new InvalidOperationException("Something is not quite right, You're throw wasn't found in the ThrowResult enum!");
                    }

                    valid = true;
                }
            }
            Console.WriteLine();
            Console.Clear();
            return output;
        }

        private static bool InputIsValid(string inputString, int min, int max, out int result)
        {
            result = -1;

           if(!int.TryParse(inputString, out int InputAsInt))
            { 
                return false;
            }    

           if(InputAsInt < min || InputAsInt > max)
            {
                return false;
            }

            result = InputAsInt;
            return true;
        }

        private static void ShowIntro()
        {
            var orgColor = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Rock Paper Scissors Demo");
            Console.WriteLine("Copyright 2021, Kyle Givler");
            Console.WriteLine("Released under MIT License");
            Console.WriteLine();

            Console.ForegroundColor = orgColor;
        }
    }
}
