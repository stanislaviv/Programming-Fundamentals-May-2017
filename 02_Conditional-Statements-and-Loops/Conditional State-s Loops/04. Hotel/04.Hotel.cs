using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel
{
	class Program
	{
		static void Main(string[] args)
		{
			string month = Console.ReadLine();
			int nights = int.Parse(Console.ReadLine());

			double studio_price = 0;
			double double_price = 0.0;
			double suite_price = 0.0;
			double studio_stay = 0.0;
			double double_stay = 0.0;
			double suite_stay = 0.0;

			switch (month)
			{
				case "May":
				case "October":

					studio_price = 50.0;
					double_price = 65.0;
					suite_price = 75.0;

					if (nights >7)
					{
						studio_price -= studio_price * 0.05;
						
					}
					break;

				case "June":
				case "September":

					studio_price = 60.0;
					double_price = 72.0;
					suite_price = 82.0;

					if (nights > 14)
					{
						double_price -= double_price * 0.1;
					}
					break;

				case "July":
				case "August":
				case "December":

					studio_price = 68.0;
					double_price = 77.0;
					suite_price = 89.0;

					if (nights >14)
					{
						suite_price -= suite_price * 0.15;
					}
					break;
			}

			studio_stay = studio_price * nights;
			double_stay = double_price * nights;
			suite_stay = suite_price * nights;

			if ((month == "September" || month == "October") && nights > 7)
			{
				studio_stay = studio_price * (nights - 1);

			}


			Console.WriteLine($"Studio: {studio_stay:f2} lv.");
			Console.WriteLine($"Double: {double_stay:f2} lv.");
			Console.WriteLine($"Suite: {suite_stay:f2} lv.");
		


		}
	}
}
