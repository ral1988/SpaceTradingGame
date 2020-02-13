using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTrader
{
    class App
    {
        public void Run()
        {
            var firstPlanet = new PlanetInfo("SOL");

            List<string> StarChart = new List<string>();
            StarChart.Add("SOL");

            new SpaceTrader.Menu();

            new SpaceTrader.Intro();
            
            new SpaceTrader.MapAndTravel().DisplayMap(firstPlanet);

        }
    }
}
