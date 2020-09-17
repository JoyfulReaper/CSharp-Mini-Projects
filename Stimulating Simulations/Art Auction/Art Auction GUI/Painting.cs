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

namespace Art_Auction
{
    /// <summary>
    /// A class to represent a Painting
    /// </summary>
    public class Painting
    {
        public struct PaintingPriceRange
        {
            public int Low;
            public int Mean;
            public int High;
        }

        public string Name { get; set; }
        public int Price { get; set; }
        public PaintingPriceRange PriceRange { get; private set; }
        public int PricePaid { get; set; }
        public Boolean Owned { get; set; }
        public int PriceVariance { get; private set; }

        private static readonly Random random = new Random();

        public Painting()
        {
            Owned = false;
            Price = 100 + (int)(900 * random.NextDouble());
            PriceVariance = (int)(Price * random.NextDouble());
            if (Price < 500)
            {
                PriceVariance = (int)(Price * 0.7 * random.NextDouble());
            }


            PriceRange = new PaintingPriceRange()
            {
                Mean = Price,
                High = (int)(Price + 0.5 * PriceVariance),
                Low = (int)(Price - 0.5 * PriceVariance)
            };
        }
    }
}
