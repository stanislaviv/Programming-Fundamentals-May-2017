using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Lecture_Sort
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int largestN = int.Parse(Console.ReadLine());
			List<int> result = new List<int>();

			BubbleSort(arr);

		

			for (int i = 0; i < largestN; i++)
			{
				result.Add(arr[i]);
			}
			Console.WriteLine(string.Join(" ", result));

			//var result1 = result.Take(largestN);                   SECOND VERSION OF PRINITNG WITH TAKE FUNCTION
			//Console.WriteLine(string.Join(" ", result1));
		}

		static void BubbleSort(int[] arr)
		{
			bool swapped = true;
			while (swapped)
			{
				swapped = false;
				for (int index = 0; index < arr.Length - 1; index++)
				{
					if (arr[index] < arr[index + 1])
					{
						SWAP(arr, index, index + 1);
						swapped = true;
					}
				}

			}

		}

		private static void SWAP(int[] arr, int firstIndex, int secondIndex)
		{
			int temp = arr[firstIndex];
			arr[firstIndex] = arr[secondIndex];
			arr[secondIndex] = temp;
		}
	}
}

