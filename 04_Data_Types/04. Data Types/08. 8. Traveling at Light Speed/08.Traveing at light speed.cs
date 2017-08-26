using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._8.Traveling_at_Light_Speed
{
	class Program
	{
		static void Main(string[] args)
		{
			decimal light_years = decimal.Parse(Console.ReadLine());

			decimal lightYear = 9450000000000m;
			decimal light_speed = 300000m;


			decimal totalKilometers = light_years * lightYear;
			decimal totalSeconds = totalKilometers / light_speed;

			decimal weeks = totalSeconds / (60 * 60 * 24 * 7);
			decimal weeksRemainder = totalSeconds % (60 * 60 * 24 * 7);
			decimal days = weeksRemainder / (60 * 60 * 24);
			decimal daysRemainder = weeksRemainder % (60 * 60 * 24);
			decimal hours = daysRemainder / (60 * 60);
			decimal hoursRemainder = daysRemainder % (60 * 60);
			decimal minutes = hoursRemainder / 60;
			decimal seconds = hoursRemainder % 60;

			Console.WriteLine(Math.Floor(weeks)+" weeks");
			Console.WriteLine(Math.Floor(days)+" days");
			Console.WriteLine(Math.Floor(hours)+" hours");
			Console.WriteLine(Math.Floor(minutes)+" minutes");
			Console.WriteLine(Math.Floor(seconds)+" seconds");

			


		}
	}
}
