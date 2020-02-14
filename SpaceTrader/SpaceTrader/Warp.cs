using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace SpaceTrader
{

    class Warp
    { /*
		var factor;
		var speed;
		var time;
		var distance;
		var result;
		var resultFactor;
		var resultSpeed;
		var resultTime;
		var resultDistance;

		private double roundResult(double result)
		{
			if (result != "err" && result != "âˆž" && result != "invalid")
			{
				result = result * 100;
				result = Math.Round(result);
				result = result / 100;
			}
			return result;
		}

		private double Log10(double x) { return Math.Log(10) * Math.Log10(x); }

		
		private void  performCalculation()
		{
			//	var findFor = widget.PreferenceForKey('findFor');
			    var findFor = "";
			    if (findFor == "Distance")
			    {
			    	findDistance();
			    }
			    if (findFor == "Time")
			    {
			    	findTime();
			    }
			    if (findFor == "Speed")
			    {
			    	findSpeed();
			    }
		}

		public double StandardizeTime(double result)
		{
			var unitTime = "";
			if (unitTime != "y")
			{
				if (unitTime == "d")
				{
					result = result / 365.25;
				}
				if (unitTime == "h")
				{
					result = result / 365.25 / 24;
				}
				if (unitTime == "m")
				{
					result = result / 365.25 / 24 / 60;
				}
				if (unitTime == "s")
				{
					result = result / 365.25 / 24 / 60 / 60;
				}
			}
			return result;
		}

		private double StandardizeDistance(double result)
		{
			var unitDist = "";
			if (unitDist == "pc")
			{
				result = result * 3.2616;
			}
			if (unitDist == "au")
			{
				result = result / 63241;
			}
			if (unitDist == "km")
			{
				result = result / 9460730472580.800;
			}
			return result;
		}

		public double standardizeSpeed(double result)
		{
			var unitSpeed = "";
			if (unitSpeed == "km")
			{
				result = result / 299792.458;
			}
			return result;
		}

		public double convertTime(double result)
		{
			var unitTime = "";
			if (unitTime != "y")
			{
				if (unitTime == "d")
				{
					result = result * 365.25;
				}
				if (unitTime == "h")
				{
					result = result * 365.25 * 24;
				}
				if (unitTime == "m")
				{
					result = result * 365.25 * 24 * 60;
				}
				if (unitTime == "s")
				{
					result = result * 365.25 * 24 * 60 * 60;
				}
			}
			return result;
		}

		//public double convertDistance( double result, string unitDist)
		//{
		//	string unitDist;
		//	if (unitDist == "pc")
		//	{
		//		result = result / 3.2616;
		//	}
		//	if (unitDist == "au")
		//	{
		//		result = result * 63241;
		//	}
		//	if (unitDist == "km")
		//	{
		//		result = result * 9460730472580.800;
		//	}
		//	return result;
		//}

		//public double convertSpeed(double result)
		//{
		//	double x = result;
		//	if (unitSpeed == "km")
		//	{
		//		x = x * 299792.458;
		//	}
		//	return x;
		//}

		public void findSpeedFromFactor()
		{
			if (factor != null)
				{
					var resultSpeed = Math.Pow(factor, 3);
				}
				else
				{
					if (10 > factor && factor > 9)
					{
						var resultSpeed = WtoV(factor);
					}
					else if (factor == 10)
					{
						var resultSpeed = 'âˆž';
					}
					else if (factor > 10)
					{
						var resultSpeed = 'invalid';
					}
					else
					{
						var resultSpeed = Math.pow(factor, (10 / 3));
					}
				}
			}
		}

		private double u(double x)
		{
			// JavaScript formula by Joshua Bell
			return (x <= 0) ? 0 : 1;
		}

		private double WtoV(double w)
		{
			// JavaScript formula by Joshua Bell
			var A = 0.036528749373;
			var n = 1.79522947028;
			var uw = u(w - 9);
			var pw = (uw == 0) ? 0 : (uw * A * Math.Pow(-Math.Log(10 - w), n));
			return Math.Pow(w, 10 / 3 + pw);
		}


		public void FindFactor()
		{
			var scale = "tng";
			if (speed != null)
			{
				speed = standardizeSpeed(speed);
				
				if (scale == "tng")
				{
					if (speed > 1516)
					{
						// Berry-Shields Method:  <http://www.calormen.com/Star_Trek/warpcalc/>
						// This section of the JavaScript by Joshua Bell
						var min = 0;
						var max = 10;
						var epsilon = 0.00001;
						var iterations = 10000;
						for (var count = 1; count <= iterations && max - min > epsilon; count++)
						{
							var test = (max + min) / 2;
							var vtest = WtoV(test);
							if (vtest > speed)
							{
								max = test;
							}
							else
							{
								min = test;
							}
						}
						var resultFactor = max;
						//				var resultFactor = 'err';
					}
					else
					{
						var resultFactor = Math.Pow(speed, 3 / 10);
					}
				}
			}
		}

		private void findSpeed()
		{
			if (distance != null && time != null)
			{
				distance = standardizeDistance(distance);
				time = standardizeTime(time);
				var resultSpeed = distance / time;
				resultSpeed = convertSpeed(resultSpeed);
				resultSpeed = roundResult(resultSpeed);
				document.calculator.speed.value = resultSpeed;
				findFactor();
			}
		}

		public void findTime()
		{
			distance = document.calculator.distance.value;
			speed = document.calculator.speed.value;
			if (speed != null && speed != null)
			{
				speed = standardizeSpeed(speed);
				distance = standardizeDistance(distance);
				var resultTime = distance / speed;
				resultTime = convertTime(resultTime);
				resultTime = roundResult(resultTime);
				document.calculator.time.value = resultTime;
			}
		}

		public void findDistance()
		{
			time = Document.calculator.time.value;
			speed = document.calculator.speed.value;
			if (speed != null && time != null)
			{
				time = standardizeTime(time);
				speed = standardizeSpeed(speed);
				var resultDistance = speed * time;
				resultDistance = convertDistance(resultDistance);
				resultDistance = roundResult(resultDistance);
				document.calculator.distance.value = resultDistance;
			}
	*/	}
	}
}
