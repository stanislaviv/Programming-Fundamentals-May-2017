using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lab_02.SmallestElmntArray
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			int smallestElement = int.MaxValue;

			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] < smallestElement)
				{
					smallestElement = array[i];
				}
			}

			Console.WriteLine(smallestElement);
		}
	}
}
