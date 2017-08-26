using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lab_III._09.Price_change
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			double significanceTreshold = double.Parse(Console.ReadLine());
			double last = double.Parse(Console.ReadLine());

			for (int i = 1; i < n; i++)
			{
				double price = double.Parse(Console.ReadLine());
				double difference = CalculateDifference(last, price);
				bool isSignificantDifference = IsSignificantDifference(difference,significanceTreshold);

				printPriceChangeMessage(price, last, difference, isSignificantDifference);

				last = price;

			
			}
			
		}




		private static void printPriceChangeMessage(double currentPrice, double lastPrice, double difference, bool isSignificantDifference)
		{
			double percentDifference = difference * 100;

			if (difference == 0)
			{
				Console.WriteLine("NO CHANGE: {0}", currentPrice);
			}
			else if (!isSignificantDifference)
			{
				Console.WriteLine("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, percentDifference);
			}
			else if (difference > 0)
			{
				Console.WriteLine("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, percentDifference);
			}
			else if (difference < 0)
			{
				Console.WriteLine("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, percentDifference);
			}
		}

		private static bool IsSignificantDifference(double significanceTreshold, double difference)
		{
			return difference <= Math.Abs(significanceTreshold);
		}

		private static double CalculateDifference(double lastPrice, double currentPrice)
		{
			double difference = (currentPrice - lastPrice) / lastPrice;
			return difference;
		}
	}
}
