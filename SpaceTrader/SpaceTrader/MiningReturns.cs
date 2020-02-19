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
            if (result.Name == "Titanium")
            {
                amount = rand.Next(2, 13);
                return amount;
            }
            else if (result.Name == "Gold")
            {
                amount = rand.Next(1, 7);
                return amount;
            }
            else if (result.Name == "Platinum")
            {
                amount = rand.Next(1, 7);
                return amount;
            }
            else if (result.Name == "Vibranium")
            {
                amount = rand.Next(0, 3);
                return amount;
            }
            else
            {
                return amount;
            }

        }

        

    }


}
