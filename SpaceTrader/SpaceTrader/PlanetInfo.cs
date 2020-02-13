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
        }

        public string CurrentPlanet()
        {
            return planetName;
        }

        private void Sol()
        {
            var temp = 58.63m;
            string tempatureOutside = String.Format($"The tempature on the surface is {temp}°F");

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
