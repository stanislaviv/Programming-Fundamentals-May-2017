using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Cypher_Roulette
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			bool isReversed = false;
			string message = string.Empty;
			string previousString = string.Empty;

			for (int i = 0; i < n; i++)
			{
				string currentString = Console.ReadLine();

				if (currentString == previousString)
				{
					message = string.Empty;
					if (currentString == "spin")
					{
						n++;
					}
				}
				else
				{
					if (currentString == "spin")
					{
						isReversed = !isReversed;
						n++;
					}
					else
					{
						if (isReversed)
						{
							message = currentString + message;
						}
						else
						{
							message += currentString;
						}
					}
				}
				
				previousString = currentString;
			}
			Console.WriteLine(message);


		}
	}
}
