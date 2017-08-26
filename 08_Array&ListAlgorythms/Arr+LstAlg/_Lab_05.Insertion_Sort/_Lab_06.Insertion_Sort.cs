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
						SWAP(arr,secondIndex,secondIndex-1);
					}
					else
					{
						break;
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
