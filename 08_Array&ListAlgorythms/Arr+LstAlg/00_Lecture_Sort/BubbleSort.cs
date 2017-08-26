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

			BubbleSort(arr);
			Console.WriteLine(string.Join(" ", arr));
		}

		static void BubbleSort(int[] arr)
		{
			bool swapped = true;
			while (swapped)
			{
				swapped = false;
				for (int index = 0; index < arr.Length - 1; index++)
				{
					if (arr[index] > arr[index + 1])
					{
						SWAP(ref arr[index], ref arr[index + 1]);
						//SWAP(arr, index, index + 1);
						  //used with reference types - 2nd method

						swapped = true;
					}
				}

			}

		}

		//Method with value types converted to reference types
		private static void SWAP(ref int first, ref int second)
		{
			int temp = first;
			first = second;
			second = temp;
		}

		//Method with refference types
		private static void SWAP(int[] arr, int firstIndex, int secondIndex)
		{
			int temp = arr[firstIndex];
			arr[firstIndex] = arr[secondIndex];
			arr[secondIndex] = temp;
		}
	}
}
