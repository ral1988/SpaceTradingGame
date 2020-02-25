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
            if (amount == 1)
            {
                var price = ((basePrice * demand) / ((amount + 1) / amount));

                return price;
            }
            else if (amount > 1)
            {
                var price = ((basePrice * demand) / (amount + 1) / (amount - 1));

                return price;
            }
            else
            {
                var price = basePrice * demand * amount;

                return price;
            }
        }

        public double Buying(double demandOfPlanet, int amount, int basePrice)
        {
            var demand = demandOfPlanet;
            var marketSize = (demand * basePrice);

            //buying
            var price = (marketSize * amount);

            
            return price; 
        }
    }
}
