using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceTrader
{
    class PlayerAge
    {
        public List<double> age = new List<double> {};

        public double endOfAge = 65.00;

        public PlayerAge()
        {


        }

        public void TimeCalc(double accumlator)
        {

            if (accumlator > 0)
            {
                age.Add(accumlator);
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
