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


        private double Selling(double demandOfPlanet, int amount)
        {
            var demand = demandOfPlanet;
            var marketSize = demand * 7;

            //selling
            var amountSelling = amount;
            var price = amountSelling * demand - marketSize;

            return price;
        }

        private double Buying(double demandOfPlanet, int amount)
        {
            var demand = demandOfPlanet;
            var marketSize = demand * 7;

            var amountBuying = amount;
            var price = amountBuying * marketSize + marketSize;


            return price; 
        }
    }
   
}
