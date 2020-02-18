using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTrader
{
    class SolSupply
    {
        public double SolSelling(int amount)
        {
            var SupplyAndDemand = new SupplyAndDemand();
            var demandOfPlanet = 1.25;
            var price = SupplyAndDemand.Selling(demandOfPlanet, amount);

            return price;

        }

        public double SolBuying (int amount)
        {
            var SupplyAndDemand = new SupplyAndDemand();
            var demandOfPlanet = 1.25;
            var price = SupplyAndDemand.Buying(demandOfPlanet, amount);

            return price;
        }
    }
    
}
