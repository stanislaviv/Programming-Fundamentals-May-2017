using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zMORE_03.Camel_sBack
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> elements = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

			int CamelsBack = int.Parse(Console.ReadLine());
			int roundsCount = 0;

			while (elements.Count > CamelsBack)
			{
				elements.RemoveAt(0);
				elements.RemoveAt(elements.Count - 1);
				roundsCount++;

			}
			if (roundsCount == 0)
			{
				Console.WriteLine("already stable: {0}", string.Join(" ", elements));
			}
			else
			{
				Console.WriteLine("{0} rounds", roundsCount);
				Console.WriteLine("remaining: {0}", string.Join(" ", elements));
			}

			

		}
	}
}
