using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e._04.ArrayHistogram
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> words = new List<string>();
			List<int> counts = new List<int>();

			string[] inputStrings = Console.ReadLine().Split(' ').ToArray();

			for (int i = 0; i < inputStrings.Length; i++)
			{
				if (!words.Contains(inputStrings[i]))
				{
					words.Add(inputStrings[i]);
					counts.Add(1);
				}
				else
				{
					int index = words.IndexOf(inputStrings[i]);
					counts[index]++;
				}
			}

			BubbleSort(counts,words);


			for (int i = 0; i < counts.Count; i++)
			{
				Console.WriteLine($"{words[i]} -> {counts[i]} times " +
					$"({(((double)counts[i] / (double)inputStrings.Length) * 100):f2}%)");
			}
		}


		static void BubbleSort(List<int> list, List<string> words)
		{
			bool swapped = true;
			while (swapped)
			{
				swapped = false;
				for (int index = 0; index < list.Count - 1; index++)
				{
					if (list[index] < list[index + 1])
					{
						SWAP(list, index, index + 1);
						SWAPstring(words, index, index + 1);
						swapped = true;
					}
				}

			}

		}



		private static void SWAP(List<int> list, int firstIndex, int secondIndex)
		{
			int temp = list[firstIndex];
			list[firstIndex] = list[secondIndex];
			list[secondIndex] = temp;
		}

		private static void SWAPstring(List<string> words, int firstIndex, int secondIndex)
		{
			string tempWord = words[firstIndex];
			words[firstIndex] = words[secondIndex];
			words[secondIndex] = tempWord;
		}

	}
}
