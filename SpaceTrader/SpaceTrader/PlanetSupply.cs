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
        public double PlanetPurchaseSelection(ref int currentPlanet, int basePrice, int amount)
        {
            if (currentPlanet == 0)
            {
                var price = SolBuying(amount, basePrice);

                return price;
            }
            else if ( currentPlanet == 1)
            {
                var price = PCBBuying(amount, basePrice);

                return price;
            }
            else if (currentPlanet == 2)
            {
                var price = BSBBuying(amount, basePrice);

                return price;
            }
            else if (currentPlanet == 3)
            {
                var price = ROSS128Buying(amount, basePrice);

                return price;
            }
            else if (currentPlanet == 4)
            {
                var price = LSBBuying(amount, basePrice);

                return price;
            }
            else if (currentPlanet == 5)
            {
                var price = WOLF1061Buying(amount, basePrice);

                return price;
            }
            else if (currentPlanet == 6)
            {
                var price = GLIESE832Buying(amount, basePrice);

                return price;
            }
            else if (currentPlanet == 7)
            {
                var price = HR8832GBuying(amount, basePrice);

                return price;
            }
            else
            {
                return 0.0;
            }

        }

        public double PlanetSellingSelection(ref int currentPlanet, int basePrice, int amount)
        {
            if (currentPlanet == 0)
            {
                var price = SolSelling(amount, basePrice);

                return price;
            }
            else if (currentPlanet == 1)
            {
                var price = PCBSelling(amount, basePrice);

                return price;
            }
            else if (currentPlanet == 2)
            {
                var price = BSBSelling(amount, basePrice);

                return price;
            }
            else if (currentPlanet == 3)
            {
                var price = ROSS128Selling(amount, basePrice);

                return price;
            }
            else if (currentPlanet == 4)
            {
                var price = LSBSelling(amount, basePrice);

                return price;
            }
            else if (currentPlanet == 5)
            {
                var price = WOLF1061Selling(amount, basePrice);

                return price;
            }
            else if (currentPlanet == 6)
            {
                var price = GLIESE832Selling(amount, basePrice);

                return price;
            }
            else if (currentPlanet == 7)
            {
                var price = HR8832GSelling(amount, basePrice);

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
            var demandOfPlanet = 1.25; //normal, everyday trading
            var price = SupplyAndDemand.Selling(demandOfPlanet, amount, basePrice);

            return price;

        }

        public double SolBuying (int amount, int basePrice)
        {

            var SupplyAndDemand = new SupplyAndDemand();
            var demandOfPlanet = 1.25; //normal, everyday trading
            var price = SupplyAndDemand.Buying(demandOfPlanet, amount, basePrice);

            return price;
        } 
        
        public double PCBSelling(int amount, int basePrice)
        {
            var SupplyAndDemand = new SupplyAndDemand();
            var demandOfPlanet = 60.25;
            var price = SupplyAndDemand.Selling(demandOfPlanet, amount, basePrice);

            return price;

        }

        public double PCBBuying (int amount, int basePrice)
        {

            var SupplyAndDemand = new SupplyAndDemand();
            var demandOfPlanet = 60.25; //hostile enviroment. Supplies are hard to get
            var price = SupplyAndDemand.Buying(demandOfPlanet, amount, basePrice);

            return price;
        } 
        
        public double BSBSelling(int amount, int basePrice)
        {
            var SupplyAndDemand = new SupplyAndDemand();
            var demandOfPlanet = 88.25;
            var price = SupplyAndDemand.Selling(demandOfPlanet, amount, basePrice);

            return price;

        }

        public double BSBBuying (int amount, int basePrice)
        {

            var SupplyAndDemand = new SupplyAndDemand();
            var demandOfPlanet = 88.25;
            var price = SupplyAndDemand.Buying(demandOfPlanet, amount, basePrice);

            return price;
        } 
        
        public double ROSS128Selling(int amount, int basePrice)
        {
            var SupplyAndDemand = new SupplyAndDemand();
            var demandOfPlanet = 0.50; //like earth, easy trading
            var price = SupplyAndDemand.Selling(demandOfPlanet, amount, basePrice);

            return price;

        }

        public double ROSS128Buying (int amount, int basePrice)
        {

            var SupplyAndDemand = new SupplyAndDemand();
            var demandOfPlanet = 0.50; //like earth, easy trading
            var price = SupplyAndDemand.Buying(demandOfPlanet, amount, basePrice);

            return price;
        } 
        
        public double LSBSelling(int amount, int basePrice)
        {
            var SupplyAndDemand = new SupplyAndDemand();
            var demandOfPlanet = 50.5; //somewhat far from earth
            var price = SupplyAndDemand.Selling(demandOfPlanet, amount, basePrice);

            return price;

        }

        public double LSBBuying (int amount, int basePrice)
        {

            var SupplyAndDemand = new SupplyAndDemand();
            var demandOfPlanet = 50.5; //somewhat far from earth
            var price = SupplyAndDemand.Buying(demandOfPlanet, amount, basePrice);

            return price;
        } 
        
        public double WOLF1061Selling(int amount, int basePrice)
        {
            var SupplyAndDemand = new SupplyAndDemand();
            var demandOfPlanet = 125.00; //somewhat far from earth
            var price = SupplyAndDemand.Selling(demandOfPlanet, amount, basePrice);

            return price;

        }

        public double WOLF1061Buying (int amount, int basePrice)
        {

            var SupplyAndDemand = new SupplyAndDemand();
            var demandOfPlanet = 125.00; //somewhat far from earth
            var price = SupplyAndDemand.Buying(demandOfPlanet, amount, basePrice);

            return price;
        } 
        
        public double GLIESE832Selling(int amount, int basePrice)
        {
            var SupplyAndDemand = new SupplyAndDemand();
            var demandOfPlanet = 800.25; //lots of minerals in a hostile enviroment
            var price = SupplyAndDemand.Selling(demandOfPlanet, amount, basePrice);

            return price;

        }

        public double GLIESE832Buying (int amount, int basePrice)
        {

            var SupplyAndDemand = new SupplyAndDemand();
            var demandOfPlanet = 800.25; //supplies are hard to get, far away from Earth
            var price = SupplyAndDemand.Buying(demandOfPlanet, amount, basePrice);

            return price;
        }
        public double HR8832GSelling(int amount, int basePrice)
        {
            var SupplyAndDemand = new SupplyAndDemand();
            var demandOfPlanet = 200.25; //Like earth but far
            var price = SupplyAndDemand.Selling(demandOfPlanet, amount, basePrice);

            return price;

        }

        public double HR8832GBuying (int amount, int basePrice)
        {

            var SupplyAndDemand = new SupplyAndDemand();
            var demandOfPlanet = 0.25; //Like earth but far
            var price = SupplyAndDemand.Buying(demandOfPlanet, amount, basePrice);

            return price;
        }


    }
    
}
