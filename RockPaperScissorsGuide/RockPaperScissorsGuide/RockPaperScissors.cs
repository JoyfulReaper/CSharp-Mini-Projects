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
    public class RockPaperScissors
    {
        public ThrowResult GetComputerThrow()
        {
            return EnumHelper.RandomEnumValue<ThrowResult>();
        }

        public Winner DetermineWinner(ThrowResult player1Result, ThrowResult Player2Result)
        {
            Winner winner = (Winner)(-1);

            if(!EnumHelper.EnumValueIsValid(player1Result))
            {
                throw new ArgumentException("Argument is invalid.", nameof(player1Result));
            }
            if (!EnumHelper.EnumValueIsValid(Player2Result))
            {
                throw new ArgumentException("Argument is invalid.", nameof(Player2Result));
            }

            switch (player1Result)
            {
                case ThrowResult.Rock:
                    switch (Player2Result)
                    {
                        case ThrowResult.Rock:
                            winner = Winner.Tie;
                            break;
                        case ThrowResult.Paper:
                            winner = Winner.Player2;
                            break;
                        case ThrowResult.Scissors:
                            winner = Winner.Player1;
                            break;
                        default:
                            break;
                    }
                    break;
                case ThrowResult.Paper:
                    switch (Player2Result)
                    {
                        case ThrowResult.Rock:
                            winner = Winner.Player1;
                            break;
                        case ThrowResult.Paper:
                            winner = Winner.Tie;
                            break;
                        case ThrowResult.Scissors:
                            winner = Winner.Player2;
                            break;
                        default:
                            break;
                    }
                    break;
                case ThrowResult.Scissors:
                    switch (Player2Result)
                    {
                        case ThrowResult.Rock:
                            winner = Winner.Player2;
                            break;
                        case ThrowResult.Paper:
                            winner = Winner.Player1;
                            break;
                        case ThrowResult.Scissors:
                            winner = Winner.Tie;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }

            if(!EnumHelper.EnumValueIsValid(winner))
            {
                throw new InvalidOperationException("Winner value not valid");
            }

            return winner;
        }
    }
}
