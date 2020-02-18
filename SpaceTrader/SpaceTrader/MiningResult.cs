using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTrader
{
    class MiningResult
    {
        public static OreType Results(Random rand, OreType Titanium, OreType Gold, OreType Platinum, OreType Vibranium)
        {
            List<OreType> Ores = new List<OreType>();

            

            Ores.Add(Titanium);
            Ores.Add(Gold);
            Ores.Add(Platinum);
            Ores.Add(Vibranium);

            int index = rand.Next(Ores.Count);

            var minedOre = Ores[index];

            var result = minedOre;

            return result;
        }
    }
}
