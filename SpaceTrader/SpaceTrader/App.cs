using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTrader
{
    class App
    {
        public void Run()
        {

            new SpaceTrader.Menu();

            new SpaceTrader.Intro();
            
            new SpaceTrader.MapAndTravel().DisplayMap();

        }
    }
}
