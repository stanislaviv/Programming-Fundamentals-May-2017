using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Choose_Drink_2._0
{
	class Program
	{
		static void Main(string[] args)
		{
			string profession = Console.ReadLine();
			var quantity = int.Parse(Console.ReadLine());
			double price = 0.0;
			


			if (profession == "Athlete")
			{
				
				price = 0.7 * quantity;
				//Console.WriteLine($"The {profession} has to pay {price}.");
			}
			else if (profession == "Businessman" || profession == "Businesswoman")
			{
				
				price = 1.0 * quantity;
				//Console.WriteLine($"The {profession} has to pay {price}.");
			}
			else if (profession == "SoftUni Student")
			{
				
				price = 1.7 * quantity;
				//Console.WriteLine($"The {profession} has to pay {price}.");
			}
			else
			{
				
				price = 1.2 * quantity;
				//Console.WriteLine($"The {profession} has to pay {price}.");
			}
			Console.WriteLine($"The {profession} has to pay {price:f2}.");

		}
	}
}
