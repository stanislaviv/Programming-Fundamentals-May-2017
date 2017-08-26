using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
	class Program
	{
		static void Main(string[] args)
		{
			int participantsCnt = int.Parse(Console.ReadLine());

			var technicalTotal = 0.0;
			var practicalTotal = 0.0;
			var theoreticalTotal = 0.0;


			for (int i = 0; i < participantsCnt; i++)
			{
				double distanceMiles = double.Parse(Console.ReadLine());
				double cargoTons = double.Parse(Console.ReadLine());
				string teamName = Console.ReadLine();



				var participantEarnedMoney = (cargoTons * 1000 * 1.5) - (0.7 * distanceMiles * 1600 * 2.5);

				if (teamName == "Technical")
				{
					technicalTotal += participantEarnedMoney;
				}
				else if (teamName == "Theoretical")
				{
					theoreticalTotal += participantEarnedMoney;
				}
				else
				{
					practicalTotal += participantEarnedMoney;
				}

			}

			double maxProfit = Math.Max((Math.Max(technicalTotal, theoreticalTotal)), practicalTotal);
			string winner = string.Empty;

			if (maxProfit == technicalTotal)
			{
				winner = "Technical";
			}
			else if (maxProfit == theoreticalTotal)
			{
				winner = "Theoretical";
			}
			else
			{
				winner = "Practical";
			}


			Console.WriteLine($"The {winner} Trainers win with ${maxProfit:f3}.");

		}
	}
}
