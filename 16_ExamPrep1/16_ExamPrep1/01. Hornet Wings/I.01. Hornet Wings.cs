using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Hornet_Wings
{
	class Program
	{
		static void Main(string[] args)
		{
			long wingFlaps = long.Parse(Console.ReadLine());
			double distance = double.Parse(Console.ReadLine());
			int endurance = int.Parse(Console.ReadLine());

			double distanceMoved = (wingFlaps / 1000) * distance;
			long secondsToFlap = wingFlaps / 100;

			double secondsToRest = (wingFlaps / endurance) * 5;
			double totalTime = secondsToFlap + secondsToRest;



			Console.WriteLine($"{distanceMoved:F2} m.");
			Console.WriteLine($"{totalTime} s.");
		}
	}
}
