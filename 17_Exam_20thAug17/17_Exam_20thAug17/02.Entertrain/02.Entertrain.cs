using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Entertrain
{
	class Program
	{
		static void Main(string[] args)
		{
			int power = int.Parse(Console.ReadLine());
			var input = Console.ReadLine();

			List<int> wagons = new List<int>();


			while (input != "All ofboard!")
			{
				int weight = int.Parse(input);

				wagons.Add(weight);

				input = Console.ReadLine();
			}

			var currentWeight = 0;
			int averageWeight = (int)wagons.Average();
			int closest = wagons.Aggregate((x, y) => Math.Abs(x - averageWeight) < Math.Abs(y - averageWeight) ? x : y);

			for (int i = 0; i < wagons.Count; i++)
			{
				currentWeight += wagons[i];
				if (currentWeight > power)
				{
					var itemToRemove = wagons.Single(r => r == Math.Abs(closest));
					wagons.Remove(itemToRemove);
					i--;
					

					averageWeight = (int)wagons.Average();
					closest = wagons.Aggregate((x, y) => Math.Abs(x - averageWeight) < Math.Abs(y - averageWeight) ? x : y);
					
				}

				Console.Write(averageWeight+" ");
				Console.Write(closest+" ");
				Console.Write(wagons.Count+" ");

				Console.WriteLine(string.Join(" ", wagons));
				//Console.WriteLine(" " + power);

		
			}


			wagons.Reverse();


			Console.Write(string.Join(" ", wagons));
			Console.WriteLine(" " + power);


		}
	}
}
