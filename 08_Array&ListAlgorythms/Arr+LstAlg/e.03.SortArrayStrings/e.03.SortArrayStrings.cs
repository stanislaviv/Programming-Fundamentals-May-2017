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
			string[] words = Console.ReadLine().Split(' ').ToArray();

			BubbleSort(words);
			Console.WriteLine(string.Join(" ", words));
		}

		static void BubbleSort(string[] words)
		{
			bool swapped = true;
			while (swapped)
			{
				swapped = false;
				for (int index = 0; index < words.Length - 1; index++)
				{
					if (words[index].CompareTo(words[index + 1]) > 0)
					{
						SWAP(words, index, index + 1);
						swapped = true;
					}
				}

			}

		}

		private static void SWAP(string[] words, int firstIndex, int secondIndex)
		{
			string temp = words[firstIndex];
			words[firstIndex] = words[secondIndex];
			words[secondIndex] = temp;
		}
	}
}

