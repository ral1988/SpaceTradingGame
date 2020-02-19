using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceTrader
{
    class PlayerAge
    {
        public PlayerAge()
        {
            
        }

        public double TimeCalc(double accumlator)
        {

            double startAge = 18.00;
            double endOfAge = 65.00;

            var currentAge = new List<double>();

            currentAge.Add(startAge);

            if (accumlator > 0)
            {
                currentAge.Add(accumlator / 365.25);
            }


            double sum = currentAge.Sum();

            if (sum >= endOfAge)
            {
                EndOfCareer();
            }

            return sum;
        }

        private void EndOfCareer()
        {

            //logic for subtracting travel, action, and other event times from the age of 65. 
            //Graphical display of how much time you have left


        }


    }
}
