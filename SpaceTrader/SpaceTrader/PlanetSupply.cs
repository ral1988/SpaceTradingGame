using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTrader
{
    class PlanetSupply
    {
        public PlanetSupply()
        {

        }
        public double PlanetPurchaseSelection(ref int currentPlanet, int baseprice, int amount)
        {
            if (currentPlanet == 0)
            {
                var price = SolBuying(amount, baseprice);

                return price;
            }
            else if ( currentPlanet == 1)
            {
                var price = PCBBuying(amount, baseprice);

                return price;
            }
            else if (currentPlanet == 2)
            {
                var price = BSBBuying(amount, baseprice);

                return price;
            }
            else if (currentPlanet == 3)
            {
                var price = ROSS128Buying(amount, baseprice);

                return price;
            }
            else if (currentPlanet == 4)
            {
                var price = LSBBuying(amount, baseprice);

                return price;
            }
            else if (currentPlanet == 5)
            {
                var price = WOLF1061Buying(amount, baseprice);

                return price;
            }
            else if (currentPlanet == 6)
            {
                var price = GLIESE832Buying(amount, baseprice);

                return price;
            }
            else if (currentPlanet == 7)
            {
                var price = HR8832GBuying(amount, baseprice);

                return price;
            }
            else
            {
                return 0.0;
            }

        }

        public double PlanetSellingSelection(ref int currentPlanet, int baseprice, int amount)
        {
            if (currentPlanet == 0)
            {
                var price = SolSelling(amount, baseprice);

                return price;
            }
            else if (currentPlanet == 1)
            {
                var price = PCBSelling(amount, baseprice);

                return price;
            }
            else if (currentPlanet == 2)
            {
                var price = BSBSelling(amount, baseprice);

                return price;
            }
            else if (currentPlanet == 3)
            {
                var price = ROSS128Selling(amount, baseprice);

                return price;
            }
            else if (currentPlanet == 4)
            {
                var price = LSBSelling(amount, baseprice);

                return price;
            }
            else if (currentPlanet == 5)
            {
                var price = WOLF1061Selling(amount, baseprice);

                return price;
            }
            else if (currentPlanet == 6)
            {
                var price = GLIESE832Selling(amount, baseprice);

                return price;
            }
            else if (currentPlanet == 7)
            {
                var price = HR8832GSelling(amount, baseprice);

                return price;
            }
            else
            {
                return 0.0;
            }
        }

        public double SolSelling(int amount, int basePrice)
        {
            var SupplyAndDemand = new SupplyAndDemand();
            var demandOfPlanet = 1.25;
            var price = SupplyAndDemand.Selling(demandOfPlanet, amount, basePrice);

            return price;

        }

        public double SolBuying (int amount, int basePrice)
        {

            var SupplyAndDemand = new SupplyAndDemand();
            var demandOfPlanet = 1.25;
            var price = SupplyAndDemand.Buying(demandOfPlanet, amount, basePrice);

            return price;
        } 
        
        public double PCBSelling(int amount, int basePrice)
        {
            var SupplyAndDemand = new SupplyAndDemand();
            var demandOfPlanet = 1.25;
            var price = SupplyAndDemand.Selling(demandOfPlanet, amount, basePrice);

            return price;

        }

        public double PCBBuying (int amount, int basePrice)
        {

            var SupplyAndDemand = new SupplyAndDemand();
            var demandOfPlanet = 1.25;
            var price = SupplyAndDemand.Buying(demandOfPlanet, amount, basePrice);

            return price;
        } 
        
        public double BSBSelling(int amount, int basePrice)
        {
            var SupplyAndDemand = new SupplyAndDemand();
            var demandOfPlanet = 1.25;
            var price = SupplyAndDemand.Selling(demandOfPlanet, amount, basePrice);

            return price;

        }

        public double BSBBuying (int amount, int basePrice)
        {

            var SupplyAndDemand = new SupplyAndDemand();
            var demandOfPlanet = 1.25;
            var price = SupplyAndDemand.Buying(demandOfPlanet, amount, basePrice);

            return price;
        } 
        
        public double ROSS128Selling(int amount, int basePrice)
        {
            var SupplyAndDemand = new SupplyAndDemand();
            var demandOfPlanet = 1.25;
            var price = SupplyAndDemand.Selling(demandOfPlanet, amount, basePrice);

            return price;

        }

        public double ROSS128Buying (int amount, int basePrice)
        {

            var SupplyAndDemand = new SupplyAndDemand();
            var demandOfPlanet = 1.25;
            var price = SupplyAndDemand.Buying(demandOfPlanet, amount, basePrice);

            return price;
        } 
        
        public double LSBSelling(int amount, int basePrice)
        {
            var SupplyAndDemand = new SupplyAndDemand();
            var demandOfPlanet = 1.25;
            var price = SupplyAndDemand.Selling(demandOfPlanet, amount, basePrice);

            return price;

        }

        public double LSBBuying (int amount, int basePrice)
        {

            var SupplyAndDemand = new SupplyAndDemand();
            var demandOfPlanet = 1.25;
            var price = SupplyAndDemand.Buying(demandOfPlanet, amount, basePrice);

            return price;
        } 
        
        public double WOLF1061Selling(int amount, int basePrice)
        {
            var SupplyAndDemand = new SupplyAndDemand();
            var demandOfPlanet = 1.25;
            var price = SupplyAndDemand.Selling(demandOfPlanet, amount, basePrice);

            return price;

        }

        public double WOLF1061Buying (int amount, int basePrice)
        {

            var SupplyAndDemand = new SupplyAndDemand();
            var demandOfPlanet = 1.25;
            var price = SupplyAndDemand.Buying(demandOfPlanet, amount, basePrice);

            return price;
        } 
        
        public double GLIESE832Selling(int amount, int basePrice)
        {
            var SupplyAndDemand = new SupplyAndDemand();
            var demandOfPlanet = 1.25;
            var price = SupplyAndDemand.Selling(demandOfPlanet, amount, basePrice);

            return price;

        }

        public double GLIESE832Buying (int amount, int basePrice)
        {

            var SupplyAndDemand = new SupplyAndDemand();
            var demandOfPlanet = 1.25;
            var price = SupplyAndDemand.Buying(demandOfPlanet, amount, basePrice);

            return price;
        }
        public double HR8832GSelling(int amount, int basePrice)
        {
            var SupplyAndDemand = new SupplyAndDemand();
            var demandOfPlanet = 1.25;
            var price = SupplyAndDemand.Selling(demandOfPlanet, amount, basePrice);

            return price;

        }

        public double HR8832GBuying (int amount, int basePrice)
        {

            var SupplyAndDemand = new SupplyAndDemand();
            var demandOfPlanet = 1.25;
            var price = SupplyAndDemand.Buying(demandOfPlanet, amount, basePrice);

            return price;
        }


    }
    
}
