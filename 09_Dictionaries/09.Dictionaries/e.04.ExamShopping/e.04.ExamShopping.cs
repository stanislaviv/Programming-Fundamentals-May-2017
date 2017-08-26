using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e._04.ExamShopping
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, int> remainingInventory = new Dictionary<string, int>();

			string[] tokens = Console.ReadLine().Split(' ').ToArray();

			while (tokens[0] != "shopping")
			{
				string product = tokens[1];
				int quantity = int.Parse(tokens[2]);

				if (remainingInventory.ContainsKey(product))
				{
					remainingInventory[product] += quantity;
				}
				else
				{
					remainingInventory.Add(product, quantity);
				}

				tokens = Console.ReadLine().Split(' ').ToArray();
			}

			tokens = Console.ReadLine().Split(' ').ToArray();

			while (tokens[0] != "exam")
			{
				string productBought = tokens[1];
				int quantityBought = int.Parse(tokens[2]);

				if (!remainingInventory.ContainsKey(productBought))
				{
					Console.WriteLine($"{productBought} doesn't exist");
				}
				else if (remainingInventory[productBought] <= 0)
				{
					Console.WriteLine($"{productBought} out of stock");
				}
				else
				{
					remainingInventory[productBought] -= quantityBought;
				}


				tokens = Console.ReadLine().Split(' ').ToArray();

			}

			foreach (KeyValuePair<string, int> product in remainingInventory)
			{
				if (product.Value > 0)
				{
					Console.WriteLine($"{product.Key} -> {product.Value}");
				}

			}

		}
	}
}
