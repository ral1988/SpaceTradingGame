using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTrader
{
    class App
    {
        public void Run()
        {
            var currentPlanet = 0;

            List<string> StarChart = new List<string>();
            StarChart.Add("SOL");
            StarChart.Add("PC-B");
            StarChart.Add("BS-B");
            StarChart.Add("ROSS-128");
            StarChart.Add("LS-B");
            StarChart.Add("Wolf-1061");
            StarChart.Add("Gliese-832");
            StarChart.Add("HR8832-G");

            new SpaceTrader.Menu();

            new SpaceTrader.Intro();
            
            new SpaceTrader.MapAndTravel().DisplayMap(StarChart, ref currentPlanet);
            

        }
    }
}
