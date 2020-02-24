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

        public double Selling(double demandOfPlanet, int amount, int basePrice)
        {
            var demand = demandOfPlanet;

            //selling
            var amountSelling = amount;
            var price = demand - (basePrice / amountSelling);

            return price;
        }

        public double Buying(double demandOfPlanet, int amount, int basePrice)
        {
            var demand = demandOfPlanet;
            var marketSize = demand + basePrice;

            //buying
            var amountBuying = amount;
            var price = (amountBuying) * marketSize + basePrice;

            return price; 
        }
    }
}
