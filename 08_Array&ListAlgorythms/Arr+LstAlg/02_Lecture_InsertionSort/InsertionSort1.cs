using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Lecture_InsertionSort
{
	class InsertionSort1
	{
		static void Main(string[] args)
		{
			int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			InsertionSort(arr);
			Console.WriteLine(string.Join(" ", arr));
		}

		private static void InsertionSort(int[] arr)
		{
			for (int firstIndex = 0; firstIndex < arr.Length; firstIndex++)
			{
				for (int secondIndex = firstIndex; secondIndex > 0; secondIndex--)
				{
					if (arr[secondIndex - 1] > arr[secondIndex])
					{
						SWAP(ref arr[secondIndex - 1], ref arr[secondIndex]);
					}
					else
					{
						break;
					}
				}
			}
		}

		private static void SWAP(ref int first, ref int second)
		{
			int temp = first;
			first = second;
			second = temp;
		}
	}
}
