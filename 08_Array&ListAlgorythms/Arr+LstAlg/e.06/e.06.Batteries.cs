using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace е._06.Batteries
{
	class Program
	{
		static void Main(string[] args)
		{
			double[] bateriesCapacity = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
			double[] usagePerHour = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
			int hours = int.Parse(Console.ReadLine());

			double usage = 0.0;
			double energyLeft = 0.0;
			double percentageLeft = 0.0;

			for (int battery = 0; battery < bateriesCapacity.Length; battery++)
			{
				usage = usagePerHour[battery] * hours;
				energyLeft = bateriesCapacity[battery] - usage;
				percentageLeft = (energyLeft / bateriesCapacity[battery]) * 100;


				if (energyLeft > 0)
				{
					Console.WriteLine($"Battery {battery + 1}: {energyLeft:f2} mAh ({percentageLeft:f2})%");
				}
				else
				{
					int hoursPassed = 0;
					double capacityExhausted = 0.0;


					for (int j = 0; j < hours; j++)
					{
						capacityExhausted += usagePerHour[battery];
						hoursPassed++;

						bool IsDead = capacityExhausted > bateriesCapacity[battery];

						if (IsDead)
						{
							Console.WriteLine($"Battery {battery + 1}: dead (lasted {hoursPassed} hours)");
							break;

						}
					}
				}
			}

		}
	}
}
