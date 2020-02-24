using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTrader
{
    class VictoryScreen
    {
        public static void Victory(ref double Money)
        {
            if (Money >= 10000000)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("You have gotten $\u03B2 10,000,000 Space Bucks and Glurut, Grand Master of Death, is pleased and has granted you your freedom.");
                Console.WriteLine("You can now begin to live your own life. So long traveler. May the Schwarz be with you!");
                Environment.Exit(0);
            }
        }
    }
}
