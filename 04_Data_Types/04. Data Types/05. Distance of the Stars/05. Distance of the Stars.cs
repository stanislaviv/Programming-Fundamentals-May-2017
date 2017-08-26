using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Distance_of_the_Stars
{
	class Program
	{
		static void Main(string[] args)
		{
			decimal onelightYearInKilometers = 9450000000000m;
			decimal distanceFromEarthToNearestStar = 4.22m * onelightYearInKilometers;
			decimal distanceToTheCenterOfMilkyWay = 26000m * onelightYearInKilometers;
			decimal diameterOfMilkyWay = 100000m * onelightYearInKilometers;
			decimal distanceFromEarthToBeyond = 46500000000m * onelightYearInKilometers;

			Console.WriteLine($"{distanceFromEarthToNearestStar:e2}");
			Console.WriteLine($"{distanceToTheCenterOfMilkyWay:e2}");
			Console.WriteLine($"{diameterOfMilkyWay:e2}");
			Console.WriteLine($"{distanceFromEarthToBeyond:e2}");
		}
	}
}
