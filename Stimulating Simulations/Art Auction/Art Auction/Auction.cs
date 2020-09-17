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
using System.Linq.Expressions;

namespace Art_Auction
{
    public static class Auction
    {
        private static readonly Random random = new Random();
        
        /// <summary>
        /// Bid on a painting. Sets the Owned property to true and set the PricePaid Property
        /// </summary>
        /// <param name="bid">The amount to bid</param>
        /// <param name="painting">The painting to bid on</param>
        /// <param name="computerBid">The amount that the computer has bid</param>
        /// <returns>True if the painting was purchased, false if not</returns>
        public static bool BidOnPainting(int bid, Painting painting, out int computerBid)
        {
            if (painting == null)
                throw new ArgumentNullException("Painting cannot be null");

            computerBid = NormalDistribution(painting.Price, painting.PriceVariance);

            if(bid > computerBid)
            {
                painting.Owned = true;
                painting.PricePaid = bid;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Get an offer for a painting.
        /// </summary>
        /// <param name="painting">The painting to get an offer for</param>
        /// <returns>The amount that was offered for the painting provided</returns>
        public static int GetOfferOnPainting(Painting painting)
        {
            return NormalDistribution(painting.Price, painting.PriceVariance);
        }

        /// <summary>
        /// I'll be honest, I have no idea how this works.
        /// I think it picks a number a certian distance from the median price
        /// Blindly converted from BASIC to C#
        /// </summary>
        /// <param name="price">Paintings cost</param>
        /// <param name="priceVariance">Paintings price variance</param>
        /// <returns>The price or bid for a painting</returns>
        private static int NormalDistribution(int price, int priceVariance)
        {
            double dividend = 0;
            double number = (int)(65536 * random.NextDouble());
            for (int i = 1; i <= 16; i++)
            {
                double quotient = (int)number / 2;
                dividend += 2 * (number / 2 - quotient);
                number = quotient;
            }
            double output = (int)price + priceVariance * (dividend - 8) / 8;
            output += 20 * random.NextDouble();
            return (int)output;
        }
    }
}
