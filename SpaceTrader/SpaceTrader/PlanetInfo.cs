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
    }
}
