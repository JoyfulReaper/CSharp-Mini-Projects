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

using System;
using System.Collections.Generic;
using System.Text;

namespace GuessLibrary
{
    public enum GuessResult { Low, High, Correct };

    public class Guess
    {
        private readonly int maxTries;
        private readonly int winningNumber;
        private int numGuesses;
        private bool gameWon = false;
        private readonly Random rand = new Random();

        public bool GameOver => numGuesses >= maxTries || gameWon;
        public int GuessesUsed => numGuesses;
        public int GuessesRemaing => maxTries - numGuesses;
        public bool GameWon => gameWon;

        /// <summary>
        /// Create a Guess Object
        /// </summary>
        /// <param name="maxTries">Maximum number of tried</param>
        /// <param name="maxNumber">Maximum number to pick</param>
        public Guess(int maxTries, int maxNumber)
        {
            this.maxTries = maxTries;
            winningNumber = rand.Next(1, maxNumber + 1);
        }

        /// <summary>
        /// Make a guess!
        /// </summary>
        /// <param name="guess"></param>
        /// <returns>GuessResult indicating if the guess is low, correct or high</returns>
        public GuessResult MakeGuess(int guess)
        {
            if (numGuesses >= maxTries)
            {
                throw new InvalidOperationException("The maximum number of guesses has been reached!");
            }

            if (GameOver)
            {
                throw new InvalidOperationException("This game has already been completed!");
            }

            numGuesses++;
            if(guess == winningNumber)
            {
                gameWon = true;
                return GuessResult.Correct;
            }
            else if (guess > winningNumber)
            {
                return GuessResult.High;
            }
            else
            {
                return GuessResult.Low;
            }
        }
    }
}
