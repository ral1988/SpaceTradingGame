using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace SpaceTrader
{

    class Warp
	{
		public static double WarpCompute(double distance)   
		{
		double f = 0.0;
		double p = 10.0 / 3.0;
		double warpInput = 4.0;

		//if (warpInput > 9.0)
		//{
		//	var f = -0.5 * Math.Log(10 - warpInput) / Math.Log(10);
		//}

		// compute some results
		var result = Math.Pow(warpInput, p + f);
		
		if (result > 0)
		   {
				var velocity =  distance / result;
				return velocity;
			}

		else
			{
				var timeOfTravel = 365.25 * distance / result;
				return timeOfTravel;
			}
		
		    
		}

	}
}
