using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Restaurant_Disc
{
	class Program
	{
		static void Main(string[] args)
		{
			var guests = int.Parse(Console.ReadLine());
			string package = Console.ReadLine();
			string hall_name = "";

			var hall_price = 0.0;
			var discount = 0.0;
			var package_price = 0.0;

			if (guests<120)
			{
				if (guests <= 50)
				{
					hall_price = 2500;
					hall_name = "Small Hall";
				}
				else if (guests > 50 && guests <= 100)
				{
					hall_price = 5000;
					hall_name = "Terrace";
				}
				else
				{
					hall_price = 7500;
					hall_name = "Great Hall";
				}



				if (package == "Normal")
				{
					discount = 0.05;
					package_price = 500;
				}
				else if (package == "Gold")
				{
					discount = 0.1;
					package_price = 750;
				}
				else
				{
					discount = 0.15;
					package_price = 1000;
				}

				var total_price_before_discount = hall_price + package_price;
				var total_price_after_discount = (1 - discount) * total_price_before_discount;
				var price_per_person = total_price_after_discount / guests;

				Console.WriteLine($"We can offer you the {hall_name}");
				Console.WriteLine($"The price per person is {price_per_person:f2}$");
			}
			else
			{
				Console.WriteLine("We do not have an appropriate hall.");
			}

			



		}
	}
}
