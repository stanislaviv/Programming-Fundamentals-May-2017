using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Numbers_to_words
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			string numberInWords = string.Empty;

			for (int i = 0; i < n; i++)
			{
				int inputNumber = int.Parse(Console.ReadLine());
				if (inputNumber > -99 && inputNumber < 99)
				{
					continue;
				}
				if (inputNumber > 999)
				{
					Console.WriteLine("too large");
				}
				else if (inputNumber < -999)
				{
					Console.WriteLine("too small");
				}
				else if (inputNumber < 99 || inputNumber > 99)
				{
					numberInWords = Letterize(inputNumber);
					Console.WriteLine(numberInWords);
				}
			}
		}

		private static string Letterize(int inputNumber)
		{
			if (inputNumber == 0)
			{
				return "zero";
			}
			if (inputNumber < 0)
			{
				return "minus " + Letterize(Math.Abs(inputNumber));
			}

			string inWords = string.Empty;

			if ((inputNumber / 100) > 0)
			{
				inWords += Letterize(inputNumber / 100) + "-hundred";
				inputNumber %= 100;
			}

			if (inputNumber > 0)
			{
				if (inWords != "")
				{
					inWords += " and ";
				}

				var unitsWords = new[] {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten",
										"eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen",
										"seventeen", "eighteen", "nineteen"};

				var tensInWords = new[] {"zero", "ten", "twenty", "thirty", "forty", "fifty",
										"sixty", "seventy", "eighty", "ninety"};

				if (inputNumber < 20)
				{
					inWords += unitsWords[inputNumber];
				}
				else
				{
					inWords += tensInWords[inputNumber / 10];

					if ((inputNumber % 10) > 0)
					{
						inWords += " " + unitsWords[inputNumber % 10];
					}
				}
			}

			return inWords;
		}
	}
}
