using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Lecture_Samples
{
	class ReverseInPlace
	{
		static void Main(string[] args)
		{
			// REVERSE ARRAY IN PLACE V1

			//int[] arr = Console.ReadLine().Split(' ' ).Select(int.Parse).ToArray();

			//for (int i = 0; i < arr.Length / 2; i++)
			//{
			//	var temp = arr[i];
			//	arr[i] = arr[arr.Length - 1 - i];
			//	arr[arr.Length - 1 - i] = temp;
			//}
			//Console.WriteLine(string.Join(" ", arr));


			//REVERSE ARRAY IN PLACE V2

			//int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			//int left = 0;
			//int right = arr.Length - 1;

			//while (left < right)
			//{
			//	int temp = arr[left];
			//	arr[left] = arr[right];
			//	arr[right] = temp;

			//	left++;
			//	right--;
			//}

			//Console.WriteLine(string.Join(" ",arr));

			//REVERSE ARRAY IN PLACE V3

			int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			int[] resultArr = new int[arr.Length];
			int resultArrIndex = 0;

			for (int i = arr.Length - 1; i >= 0; i--)
			{
				resultArr[resultArrIndex] = arr[i];
				resultArrIndex++; 
			}

			Console.WriteLine(string.Join(" ",resultArr));



		}
	}
}
