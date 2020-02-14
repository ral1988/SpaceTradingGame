using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTrader
{
    class MiningResult
    {
        public static OreType Results(Random rand)
        {
            List<OreType> Ores = new List<OreType>();

            OreType Titanium = new OreType
            {
                OreName = "Titanium"
            };
            OreType Gold = new OreType
            {
                OreName = "Gold"
            };
            OreType Platinum = new OreType
            {
                OreName = "Platinum"
            };
            OreType Vibranium = new OreType
            {
                OreName = "Vibranium"
            };

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
