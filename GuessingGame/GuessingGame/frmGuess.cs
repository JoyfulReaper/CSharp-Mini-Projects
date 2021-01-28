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

using GuessLibrary;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class frmGuess : Form
    {
        private Guess game;

        public frmGuess()
        {
            InitializeComponent();

            this.ActiveControl = textBoxGuess;
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(textBoxGuess.Text, out int guess))
            {
                MessageBox.Show("Please enter a valid number!");
                return;
            }

            if(game == null || game.GameOver)
            {
                if (!ValidateGameOptions(out int maxGuess, out int maxNum))
                {
                    return;
                }

                game = new Guess(maxGuess, maxNum);
            }

            var result = game.MakeGuess(guess);

            string message;
            switch (result)
            {
                case GuessResult.Low:
                    message = $"Too low!\n{game.GuessesRemaing} Guesses left!";
                    break;
                case GuessResult.High:
                    message = $"Too high!\n{game.GuessesRemaing} Guesses left!";
                    break;
                case GuessResult.Correct:
                    message = $"You won in {game.GuessesUsed} guesses!";
                    break;
                default:
                    message = "You broke it!";
                    break;
            }

            MessageBox.Show(message, "Result!", MessageBoxButtons.OK);

            if (game.GameOver && !game.GameWon)
            {
                MessageBox.Show("You lost!", "You Lose!", MessageBoxButtons.OK);
            }

            textBoxGuess.Text = string.Empty;
        }

        private bool ValidateGameOptions(out int maxGuesses, out int maxNumber)
        {
            var message = string.Empty;

            if (!int.TryParse(textBoxMaxGuess.Text, out int maxGuess))
            {
                message += "Please enter a valid number of guesses!\n";
            }
            if (!int.TryParse(textBoxMaxNumber.Text, out int maxNum))
            {
                message += "Please enter a valid maximum number!";
            }

            maxGuesses = maxGuess;
            maxNumber = maxNum;

            if(message == string.Empty)
            {
                return true;
            }

            MessageBox.Show(message);
            return false;
        }

        private void linkLabelGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/JoyfulReaper") { UseShellExecute = true });
        }
    }
}
