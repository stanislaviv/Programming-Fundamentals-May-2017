using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zMore_Distinct_List_V2
{
	class zMore_Distinct_List_V2
	{
		static void Main(string[] args)
		{
			List<int> inputElements = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

			List<int> nonRepeatingElements = new List<int>();

			foreach (int number in inputElements)
			{
				if (!nonRepeatingElements.Contains(number))
				{
					nonRepeatingElements.Add(number);
					Console.Write(number+" ");
				}
			}
			Console.WriteLine();
		}
	}
}
