using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceTrader
{
    class PlayerAge
    {
        public List<double> age = new List<double> {};

        public PlayerAge()
        {


        }

        public void TimeCalc(double accumlator)
        {

            double endOfAge = 65.00;

            if (age.Sum() < 18)
            {
                age.Add(18);
            }


            if (accumlator > 0)
            {
                age.Add(accumlator / 365.25);
            }


            double sum = age.Sum();

            if (sum >= endOfAge)
            {
                EndOfCareer();
            }
        }

        private void EndOfCareer()
        {

            //logic for subtracting travel, action, and other event times from the age of 65. 
            //Graphical display of how much time you have left


        }


    }
}
