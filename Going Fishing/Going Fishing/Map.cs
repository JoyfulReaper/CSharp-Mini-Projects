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
using System.Collections.Generic;

namespace Going_Fishing
{
    public class Map
    {
        public int MapSizeX { get; } = 8;
        public int MapSizeY { get; } = 8;

        private readonly Random rand = new Random();
        private readonly Location[,] locations;
        private readonly bool debug = false;

        public Map()
        {
            locations = new Location[MapSizeX, MapSizeY];

            for (int i = 0; i < MapSizeX; i++)
            {
                for (int j = 0; j < MapSizeY; j++)
                {
                    double probability = 0.7 * rand.NextDouble();
                    int density = rand.Next(6);
                    locations[i, j] = Location.CreateLocation(this, probability, density, i, j);
                }
            }

            locations[0, 0].Probability = 0;
        }

        public bool IsValidCoordinate(int x, int y)
        {
            if (x >= locations.GetLength(0) || y >= locations.GetLength(1)
                || x < 0 || y < 0)
            {
                return false;
            }
            return true;
        }

        public Location GetLocation(int x, int y)
        {
            if(IsValidCoordinate(x, y))
                return locations[x, y];

            throw new InvalidLocation("{x},{y} is not a valid location");
        }

        public bool GoFishing(int x, int y, out int numCaught, out int weight)
        {
            numCaught = 0;
            weight = 0;

            Location loc = GetLocation(x, y);
            var randNum = rand.NextDouble();
            if (randNum > loc.Probability || loc.Density < 1)
            {
                if (debug)
                {
                    Console.WriteLine($"GoFishing(No catch): {randNum} > {loc.Probability}");
                }
                return false;
            }
            else
            {
                var rand1 = rand.NextDouble();
                var rand2 = rand.NextDouble();
                numCaught = (int)(rand1 * loc.Density + 1);
                weight = (int)(rand2 * x * y + 1);

                if (debug)
                {
                    Console.WriteLine($"GoFishing(num): {rand1} * {loc.Density} + 1: {(rand1 * loc.Density + 1)}");
                    Console.WriteLine($"GoFishing(weight): {rand2} * {x} * {y} + 1: {(rand2 * x * y + 1)}");
                }
            }
            return true;
        }

        public IEnumerable<Location> GetAllLocations()
        {
            for (int i = 0; i < MapSizeX; i++)
            {
                for (int j = 0; j < MapSizeY; j++)
                {
                    yield return locations[i, j];
                }
            }
        }
    }
}
