using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.CountOfCapitalLetterArray
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] stringArray = Console.ReadLine().Split(' ');
			int countCapital = 0;

			for (int i = 0; i < stringArray.Length; i++)
			{
				string currentElement = stringArray[i];

				if (currentElement.Length == 1)
				{
					if (currentElement[0] >= 'A' && currentElement[0] <= 'Z')
					{
						countCapital++;
					}
				}
			}

			Console.WriteLine(countCapital);
		}
	}
}
