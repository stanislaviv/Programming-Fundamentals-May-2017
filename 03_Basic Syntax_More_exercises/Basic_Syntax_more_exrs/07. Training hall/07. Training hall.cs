using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Training_hall
{
	class Program
	{
		static void Main(string[] args)
		{
			var budget = double.Parse(Console.ReadLine());
			var items = int.Parse(Console.ReadLine());

			double subtotal = 0;
			double money_left = budget;

			for (int i = 1; i <= items; i++)
			{
				string item_name = Console.ReadLine();
				var item_price = double.Parse(Console.ReadLine());
				var item_count = int.Parse(Console.ReadLine());

				if (item_count > 1)
				{
					item_name += "s";
				}

				Console.WriteLine($"Adding {item_count} {item_name} to cart.");
				subtotal += (item_price*item_count);

			}

			Console.WriteLine($"Subtotal: ${subtotal:f2}");
			if (budget >= subtotal)
			{
				Console.WriteLine($"Money left: ${(budget-subtotal):f2}");
			}
			else
			{
				Console.WriteLine($"Not enough. We need ${(subtotal - budget):f2} more.");
			}
		}
	}
}
