using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTrader
{
    class PlanetSupply
    {

        public double SolSelling(int amount, OreType Titanium, OreType Gold, OreType Platinum, TradingItems Food, TradingItems Texttiles, TradingItems Electronics, TradingItems SpareParts, TradingItems Water)
        {
            var SupplyAndDemand = new SupplyAndDemand();
            var demandOfPlanet = 1.25;
            var basePrice = Titanium.Price;
            var price = SupplyAndDemand.Selling(demandOfPlanet, amount, basePrice);

            return price;

        }

        public double SolBuying (int amount)
        {

            var SupplyAndDemand = new SupplyAndDemand();
            var demandOfPlanet = 1.25;
            var basePrice = ; 
            var price = SupplyAndDemand.Buying(demandOfPlanet, amount, basePrice);

            return price;
        }


    }
    
}
