﻿using System;
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
            Sol();
            ProximaCentauriB();
            BarnardsStarB();
            Ross128B();
            LuytensStarB();
            Wolf1061C();
            Gliese832C();
            HD8832G();

            
        }

        public string CurrentPlanet()
        {
            return planetName;
        }

        private void Sol()
        {
            
            var temp = 58.63m;
            string tempatureOutside = String.Format($"The tempature on the surface is {temp}°F");
            var light = "Perfect";
            string surfaceLight = String.Format($"The surface light on this planet is {light} times Earth");
            double mass = 1.0;
            string massOfPlanet = String.Format($"The mass on this planet is {mass} times Earth");
            double gravity = 1.0;
            string gravityOfPlanet = String.Format($"The gravity on this planet is {gravity} times Earth");
            string atmosphere = "Earth";
            string atmosphereOfPlanet = String.Format($"The atmosphere is like {atmosphere}");

        }
        private void ProximaCentauriB()
        {
            var temp = -38.0m;
            string tempatureOutside = String.Format($"The tempature on the surface is {temp}°F");
            var light = "no brighter than twilight";
            string surfaceLight = String.Format($"The surface light on this planet is {light} times Earth");
            double mass = 1.27;
            string massOfPlanet = String.Format($"The mass on this planet is {mass} times Earth");
            double gravity = 1.1;
            string gravityOfPlanet = String.Format($"The gravity on this planet is {gravity} times Earth");
            string atmosphere = "thick Hydrogen Clouds on surface, thin atmosphere otherwise";
            string atmosphereOfPlanet = String.Format($"The atmosphere has {atmosphere}");
        }

        private void BarnardsStarB()
        {
            var temp = -274.0m;
            string tempatureOutside = String.Format($"The tempature on the surface is {temp}°F");
            var light = "Perfect";
            string surfaceLight = String.Format($"The surface light on this planet is {light} times Earth");
            double mass = 1.0;
            string massOfPlanet = String.Format($"The mass on this planet is {mass} times Earth");
            double gravity = 1.0;
            string gravityOfPlanet = String.Format($"The gravity on this planet is {gravity} times Earth");
            string atmosphere = "Earth";
            string atmosphereOfPlanet = String.Format($"The atmosphere is like {atmosphere}");
        }

        private void Ross128B()
        {
            var temp1 = 92.0m;
            var temp2 = 62.0m;
            string tempatureOutside = String.Format($"The tempature on the surface is \n{temp1}°F on the light side and {temp2}°F on the dark side");
            var light = "38% brighter than Earth";
            string surfaceLight = String.Format($"The surface light on this planet is {light} times Earth");
            double mass = 1.35;
            string massOfPlanet = String.Format($"The mass on this planet is {mass} times Earth");
            double gravity = 1.12;
            string gravityOfPlanet = String.Format($"The gravity on this planet is {gravity} times Earth");
            string atmosphere = "earth like";
            string atmosphereOfPlanet = String.Format($"The atmosphere is {atmosphere}");
        }

        private void LuytensStarB()
        {
            var temp1 = 66.0m;
            var temp2 = 45.0m;
            string tempatureOutside = String.Format($"The tempature on the surface is \n{temp1}°F on the light side and {temp2}°F on the dark side");
            var light = "6% brighter than Earth";
            string surfaceLight = String.Format($"The surface light on this planet is {light} times Earth");
            double mass = 3.0;
            string massOfPlanet = String.Format($"The mass on this planet is {mass} times Earth");
            double gravity = 1.4;
            string gravityOfPlanet = String.Format($"The gravity on this planet is {gravity} times Earth");
            string atmosphere = "Earth";
            string atmosphereOfPlanet = String.Format($"The atmosphere is like {atmosphere}");
        }

        private void Wolf1061C()
        {
            var temp1 = 135.0m;
            var temp2 = -58.0m;
            string tempatureOutside = String.Format($"The tempature on the surface is \n{temp1}°F on the light side and {temp2}°F on the dark side");
            var light = "15% brighter than Earth";
            string surfaceLight = String.Format($"The surface light on this planet is {light} times Earth");
            double mass = 4.3;
            string massOfPlanet = String.Format($"The mass on this planet is {mass} times Earth");
            double gravity = 1.6;
            string gravityOfPlanet = String.Format($"The gravity on this planet is {gravity} times Earth");
            string atmosphere = "thin";
            string atmosphereOfPlanet = String.Format($"The atmosphere is {atmosphere}");
        }
        
        private void Gliese832C()
        {
            var temp = 800.00m;
            string tempatureOutside = String.Format($"The tempature on the surface is {temp}°F");
            var light = "Earth";
            string surfaceLight = String.Format($"The surface light on this planet is {light} times Earth");
            double mass = 5.2;
            string massOfPlanet = String.Format($"The mass on this planet is {mass} times Earth");
            double gravity = 1.7;
            string gravityOfPlanet = String.Format($"The gravity on this planet is {gravity} times Earth");
            string atmosphere = "thick and toxic";
            string atmosphereOfPlanet = String.Format($"The atmosphere is {atmosphere}");
        }

        private void HD8832G()
        {
            var temp = 98.00m;
            string tempatureOutside = String.Format($"The tempature on the surface is {temp}°F");
            var light = "like Earth";
            string surfaceLight = String.Format($"The surface light on this planet is {light}");
            double mass = 11.0;
            string massOfPlanet = String.Format($"The mass on this planet is {mass} times Earth");
            double gravity = 1.9;
            string gravityOfPlanet = String.Format($"The gravity on this planet is {gravity} times Earth");
            string atmosphere = "Earth";
            string atmosphereOfPlanet = String.Format($"The atmosphere is like {atmosphere}");
        }
    }
}
