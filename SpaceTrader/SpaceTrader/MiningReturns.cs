using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SpaceTrader
{
    class MiningReturns
    {
        // Returns a random amount based on the ore type mined.
        public static int Returns(OreType result)
        {
            //Calls the random generator class
            Random rand = RandomGenerator.NewRand();

            int amount = 0;

            //Most common -> Least Common
            if (result.OreName == "Titanium")
            {
                amount = rand.Next(2, 10);
                return amount;
            }
            else if (result.OreName == "Gold")
            {
                amount = rand.Next(1, 8);
                return amount;
            }
            else if (result.OreName == "Platinum")
            {
                amount = rand.Next(1, 8);
                return amount;
            }
            else if (result.OreName == "Vibranium")
            {
                amount = rand.Next(0, 4);
                return amount;
            }
            else
            {
                return amount;
            }

        }

        

    }


}
