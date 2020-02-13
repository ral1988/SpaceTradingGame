using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTrader
{
    class PlanetInfo
    {
        string planetName;

        public PlanetInfo(string planetName)
        {
            this.planetName = planetName;
            Tuple<string, double, double>[] plantLocation =
            {new Tuple<string, double, double>("Sol", 0.0, 0.0),
             new Tuple<string, double, double>("ProximaCentauriB", 2.646, -3.0),
             new Tuple<string, double, double>("BarnardsStarB", 4.0, 4.472),
             new Tuple<string, double, double>("Ross128B", 0.0, -11.0),
             new Tuple<string, double, double>("LuytensStarB", -10.392, -6.0),
             new Tuple<string, double, double>("Wolf1061C", 9.798, 10.0),
             new Tuple<string, double, double>("Gliese832C", 15.0, -5.56776),
             new Tuple<string, double, double>("HD8832G", -13.601, 16.0),
            };
        }

        public string CurrentPlanet()
        {
            return planetName;
        }

        private void Sol()
        {
            
            var temp = 58.63m;
            string tempatureOutside = String.Format($"The tempature on the surface is {temp}°F");
            double mass = 1.0;
            double grav = 1.0;
            string atmosphere = "Earth";

        }
        private void ProximaCentauriB()
        {

        }

        private void BarnardsStarB()
        {

        }

        private void Ross128B()
        {

        }

        private void LuytensStarB()
        {

        }

        private void Wolf1061C()
        {

        }
        
        private void Gliese832C()
        {

        }

        private void HD8832G()
        {

        }
    }
}
