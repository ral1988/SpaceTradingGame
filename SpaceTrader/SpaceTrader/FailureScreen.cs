using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SpaceTrader
{
    class FailureScreen
    {
        public FailureScreen()
        {

        }
        public void Failure(ref double Money, List<double> age, double endOfAge)
        {
            if (Money <= 0)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("You ran out of Space Bucks and Glurut, Grand Master of Death, has sent 42 assassins to rip out your spleen for him to feast on.");
                Console.WriteLine("You have failed. Maybe in another life...");
                Environment.Exit(0);
            }

            if (age.Sum() >= endOfAge)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("You ran out of Time and Glurut, Grand Master of Death, has sent 42 assassins to rip out your spleen for him to feast on.");
                Console.WriteLine("You have failed. Maybe in another life...");
                Environment.Exit(0);
            }
        }
    }
}
