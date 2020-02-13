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

        private void Wolf1061C()
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
        
        private void Gliese832C()
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

        private void HD8832G()
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
    }
}
