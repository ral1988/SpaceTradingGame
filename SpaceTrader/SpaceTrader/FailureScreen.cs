using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTrader
{
    class FailureScreen
    {
        public FailureScreen()
        {

        }
        public void Failure(ref double Money)
        {
            if (Money == 0)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("You ran out of Space Bucks and Glurut, Grand Master of Death, has sent 42 assassins to rip out your spleen for him to feast on.");
                Console.WriteLine("You have failed. Maybe in another life...");
                Environment.Exit(0);
            }
        }
    }
}
