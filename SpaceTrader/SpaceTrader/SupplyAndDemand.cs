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
            var price = ((demand * basePrice) / amount) + ((basePrice + 100)/basePrice);

            if (price > amount * basePrice * 10)
            {
                price = amount * basePrice * 10;
               
                return price;
            }

            if (price > 250000.00 * amount)
            {
                price = 250000.00 * amount;
                return price;
            }

            return price;
        }

        public double Buying(double demandOfPlanet, int amount, int basePrice)
        {
            var demand = demandOfPlanet;
            var marketSize = demand * basePrice;

            //buying
            var price = marketSize * amount;

            if (price > amount * basePrice * 2.5)
            {
                price = amount * basePrice * 2.5;
                if (price > 250000.00 * amount)
                {
                    price = 250000.00 * amount;
                    return price;
                }

                return price;
            }
           
            return price; 
        }
    }
}
