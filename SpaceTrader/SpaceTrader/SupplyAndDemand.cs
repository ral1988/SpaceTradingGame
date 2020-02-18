﻿using System;
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
            var marketSize = demand * 7 + basePrice;

            //selling
            var amountSelling = amount;
            var price = amountSelling * demand - marketSize ;

            return price;
        }

        public double Buying(double demandOfPlanet, int amount, int basePrice)
        {
            var demand = demandOfPlanet;
            var marketSize = demand * 7 + basePrice;

            var amountBuying = amount;
            var price = amountBuying * marketSize + marketSize;


            return price; 
        }
    }
   
}
