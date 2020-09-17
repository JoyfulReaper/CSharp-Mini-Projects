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

namespace Going_Fishing
{
    public class Location
    {
        public double Probability { get; set; }
        public int Density { get; set; }

        public int XCoord { get; private set; }
        public int YCoord { get; private set; }

        private Location(double probability, int density, int x, int y)
        {
            Probability = probability;
            Density = density;
            XCoord = x;
            YCoord = y;
        }

        public static Location CreateLocation(Map map, double probability, int density, int x, int y)
        {
            if (!map.IsValidCoordinate(x, y))
            {
                throw new InvalidLocation($"{x},{y} is not a valid location on the provided Map.");
            }
            return new Location(probability, density, x, y);
        }
    }
}
