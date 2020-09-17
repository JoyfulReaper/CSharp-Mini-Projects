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
    public class Player
    {
        public int PlayerX { get; private set; } = 0;
        public int PlayerY { get; private set; } = 0;
        public int Pounds { get; set; }

        public void SetPlayerCoordinates(Map map, int x, int y)
        {
            if (!map.IsValidCoordinate(x, y))
            {
                throw new InvalidLocation("Coordinates are out of bounds!");
            }

            PlayerX = x;
            PlayerY = y;
        }

        public bool Move(Map map, char option)
        {
            try
            {
                switch (option)
                {
                    case 'N':
                        SetPlayerCoordinates(map, PlayerX, PlayerY + 1);
                        break;
                    case 'S':
                        SetPlayerCoordinates(map, PlayerX, PlayerY - 1);
                        break;
                    case 'E':
                        SetPlayerCoordinates(map, PlayerX + 1, PlayerY);
                        break;
                    case 'W':
                        SetPlayerCoordinates(map, PlayerX - 1, PlayerY);
                        break;
                    default:
                        return false;
                }
            }
            catch (InvalidLocation)
            {
                return false;
            }
            return true;
        }
    }
}
