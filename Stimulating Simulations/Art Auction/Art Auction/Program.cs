/*Adapted from "Stimulating Simulations" (C) 1977 C. William Engel. (C) 1979 by Hayden Book
 Adapted from BASIC to C# by Kyle Givler 
 https://github.com/JoyfulReaper/Mini-Projects
 Special thanks to to following website: www.trs-80.com/wordpress/info-level-2-basic-language

MIT License

Copyright(c) 2020 Kyle Givler

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

namespace Art_Auction
{
    class Program
    {
        private static ConsoleColor startingColor;
        private static readonly int numberOfPaintings = 5;
        private static readonly Random random = new Random();
        static void Main()
        {
            startingColor = Console.ForegroundColor;
            Console.CancelKeyPress += new ConsoleCancelEventHandler(OnProcessExit);
            SetConsoleForeground(ConsoleColor.White);
            ShowIntro();

            var paintings = CreatePaintings(numberOfPaintings);

            BuyPaintings(paintings);
            int profit = SellPaintings(paintings);

            GameOver(profit);
            Console.ForegroundColor = startingColor;
        }

        private static void ShowIntro()
        {
            Console.WriteLine("\nArt Auction\n");
            Console.WriteLine("Adapted from \"Stimulating Simulations\" (C) 1977 C. William Engel. (C) 1979 by Hayden Book");
            Console.WriteLine("Adapted from BASIC into C# by:");
            Console.WriteLine("Kyle Givler April 2020 - github.com/JoyfulReaper\n");

            Console.WriteLine("Buy paintings at auction and attempt to re-sell them at a higher price.");
            Console.WriteLine("The 3 numbers represent the mean and range of the bids. About 70% of the bids will be in this range.\n");
        }

        private static void GameOver(int profit)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Your profit is ${0}", profit);
            Console.Write("Would you like to play again? (Y/N) ");
            string again = Console.ReadLine();
            if (char.ToUpper(again[0]) == 'Y')
            {
                Console.WriteLine();
                Main();
            }
            SetConsoleForeground(startingColor);
            System.Environment.Exit(System.Environment.ExitCode);
        }

        private static void BuyPaintings(List<Painting> paintings)
        {
            SetConsoleForeground(ConsoleColor.Green);
            Console.WriteLine("-------- Buying Paintings --------\n");

            for (int i = 0; i < paintings.Count; i++)
            {
                int yourBid;
                SetConsoleForeground(ConsoleColor.Cyan);
                Console.Write($"Bidding on painting #");
                SetConsoleForeground(ConsoleColor.Yellow);
                Console.WriteLine(i + 1);
                SetConsoleForeground(ConsoleColor.Cyan);
                Console.WriteLine("Price range: (Low / Mean / High) ${0} ${1} ${2}", paintings[i].PriceRange.Low, paintings[i].PriceRange.Mean, paintings[i].PriceRange.High);

                do
                {
                    Console.Write("What is your bid? ");
                } while (!Int32.TryParse(Console.ReadLine(), out yourBid) && yourBid < 0);

                var purchased = Auction.BidOnPainting(yourBid, paintings[i], out int computerBid);
                Console.WriteLine($"Your opponent has bid ${computerBid}");
                if (purchased)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You won the auction!\n");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You were out bid.\n");
                }
            }
        }

        private static int SellPaintings(List<Painting> paintings)
        {
            SetConsoleForeground(ConsoleColor.Magenta);
            Console.WriteLine("-------- Selling Paintings --------\n");

            SetConsoleForeground(ConsoleColor.Yellow);
            int profit = 0;

            for (int i = 0; i < paintings.Count; i++)
            {
                if (!paintings[i].Owned)
                {
                    continue;
                }

                int numOffers = random.Next(1, 6);

                Console.Write("Selling painting #");
                SetConsoleForeground(ConsoleColor.Red);
                Console.WriteLine("{0}", i + 1);
                SetConsoleForeground(ConsoleColor.Yellow);
                Console.WriteLine("You bought it for ${0}", paintings[i].PricePaid);
                Console.WriteLine("The average offer is: {0}", paintings[i].Price + 50);
                for (int j = 0; j < numOffers; j++)
                {
                    int offer = Auction.GetOfferOnPainting(paintings[i]);
                    Console.Write("Offer #");
                    SetConsoleForeground(ConsoleColor.Red);
                    Console.Write(j + 1);
                    SetConsoleForeground(ConsoleColor.Yellow);
                    Console.WriteLine($" is {offer}");
                    Console.Write("Accept this offer? ");
                    string accept = Console.ReadLine();
                    Console.WriteLine();
                    if (Char.ToUpper(accept[0]) == 'Y')
                    {
                        paintings[i].Owned = false;
                        profit += offer - paintings[i].PricePaid;
                        break;
                    }
                }
            }
            return profit;
        }

        private static List<Painting> CreatePaintings(int num)
        {
            List<Painting> paintings = new List<Painting>(num);
            for(int i = 0; i < num; i++)
            {
                paintings.Add(new Painting());
            }
            return paintings;
        }

        private static void SetConsoleForeground(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }

        static void OnProcessExit(object sender, EventArgs e)
        {
            Console.ForegroundColor = startingColor;
            System.Environment.Exit(0);
        }
    }
}
