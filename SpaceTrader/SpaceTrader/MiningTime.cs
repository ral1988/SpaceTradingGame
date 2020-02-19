using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTrader
{
    class MiningTime
    {
        public static double TimeElapsed()
        {
            var addToAge = new PlayerAge();

            double timeToMine = 0;

            Random rand = RandomGenerator.NewRand();

            timeToMine = rand.NextDouble();

            if (timeToMine == 0.0)
            {
                timeToMine += 0.1;
            }

            timeToMine /= 2;

            timeToMine *= 365.25;

            
            return timeToMine;
        }
    }
}
