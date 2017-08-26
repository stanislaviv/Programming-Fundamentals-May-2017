using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lab._04.FoldAndSum
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] InitialNumbers = Console.ReadLine()
				.Split(' ')
				.Select(int.Parse)
				.ToArray();

			int k = InitialNumbers.Length / 4;

			int[] leftPart = InitialNumbers.Take(k).Reverse().ToArray();
			int[] rightPart = InitialNumbers.Reverse().Take(k).ToArray();

			int[] downArray = InitialNumbers.Skip(k).Take(2 * k).ToArray();
			int[] upperPart = leftPart.Concat(rightPart).ToArray();

			for (int i = 0; i < downArray.Length; i++)
			{
				downArray[i] += upperPart[i];

			}

			Console.WriteLine(string.Join(" ", downArray));


			//USING LAMBDA TO PRINT THE RESULT

			//var resultArray = upperPart.Select((x, index) => x + downArray[index]);
			//Console.WriteLine(string.Join(" ", resultArray));


		}
	}
}
