using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTrader
{
    class SupplyAndDemand
    {
        public SupplyAndDemand()
        {

        }

        
        private void SDFormulas(double a, int b, PlanetInfo)
        {
            var basePrice = a;                    //baseprice is universal across the map based on the item type
            var localDemand = PlanetInfo.;        //planet determines the local demand
            var demandFactor = ;
            var unitsInDemand = PlanetInfo.;      //a ratio of how much the planet you are at wants this item
            var localSupply = PlanetInfo.;        //What is in supply on the local planet
            var supplyFactor = ;
            var unitsSupplied = b;                //how many the end user is requesting

            var price = basePrice * (localDemand + demandFactor * unitsInDemand) / (localSupply + supplyFactor * unitsSupplied);
        }

    }
}
