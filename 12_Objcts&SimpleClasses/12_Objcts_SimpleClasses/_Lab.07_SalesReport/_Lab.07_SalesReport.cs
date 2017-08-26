using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lab._07_SalesReport
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			List<Sale> sales = new List<Sale>();

			for (int i = 0; i < n; i++)
			{
				Sale sale = ReadSale(Console.ReadLine());
				sales.Add(sale);
			}

			List<string> towns = sales
				.Select(sale => sale.Town)
				.Distinct()
				.OrderBy(town => town)
				.ToList();

			foreach (string town in towns)
			{
				double currentSum = sales
					.Where(sale => sale.Town == town)
					.Select(sale => sale.Price * sale.Quantity)
					.Sum();

				Console.WriteLine($"{town} -> {currentSum:f2}");
			}
		}

		private static Sale ReadSale(string input)
		{
			string[] tokens = input.Split(' ');
			string town = tokens[0];
			string product = tokens[1];
			double price = double.Parse(tokens[2]);
			double qty = double.Parse(tokens[3]);

			return new Sale
			{
				Town = town,
				Product = product,
				Price = price,
				Quantity = qty
			};

		}

		class Sale
		{
			public string Town { get; set; }
			public string Product { get; set; }
			public double Price { get; set; }
			public double Quantity { get; set; }
		}
	}
}
