using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lab_01.Array_contains_elmnt
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int element = int.Parse(Console.ReadLine());

			bool containsElement = false;

			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] == element)
				{
					containsElement = true;
					break;
				}
			}

			if (containsElement)
			{
				Console.WriteLine("yes");
			}
			else
			{
				Console.WriteLine("no");
			}
		}
	}
}
