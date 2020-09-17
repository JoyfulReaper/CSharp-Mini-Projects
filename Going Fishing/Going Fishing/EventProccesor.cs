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

namespace Going_Fishing
{
    public class EventProccesor
    {
        private Map map;
        private Player player;
        private static Random rand = new Random();

        public EventProccesor(Map map, Player player)
        {
            this.map = map;
            this.player = player;
        }

        public bool ProccessUnepectedEvents(ref int moveNumber, out string message)
        {
            message = null;
            decimal time = (decimal)moveNumber / 10m + .1m;
            int eventNumber = (int)(100 * rand.NextDouble()) + 1;
            if(eventNumber < 5)
            {
                switch (eventNumber)
                {
                    case 1:
                        var locations = map.GetAllLocations();
                        message = "The fish are scared by a shark, they are not biting as often.";
                        foreach(var loc in locations)
                        {
                            loc.Probability -= 1;
                        }
                        break;
                    case 2:
                        message = "Sea gulls eat some of your bait! The catch will be smaller this trip.";
                        locations = map.GetAllLocations();
                        foreach(var loc in locations)
                        {
                            loc.Density -= 1;
                        }
                        break;
                    case 3:
                        int randX = rand.Next(0, map.MapSizeX + 1);
                        int randY = rand.Next(0, map.MapSizeY + 1);
                        player.SetPlayerCoordinates(map, randX, randY);
                        message = $"A water spout displaces you! You are now at {randX},{randY}!";
                        moveNumber += 2;
                        break;
                    case 4:
                        message = "You caught a 50 lbs. shark!";
                        player.Pounds += 50;
                        break;
                }
                return true;
            }

            if(rand.NextDouble() < (double)time / 60)
            {
                if (message == null)
                {
                    message = "A nasty storm causes you to lose a 1/2 hour!";
                }
                else
                {
                    message += "\nA nasty storm causes you to lose a 1/2 hour!";
                }
                moveNumber += 5;
                return true;
            }

            return false;
        }
    }
}
