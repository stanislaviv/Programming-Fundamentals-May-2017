using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lab_02_Multiply_array_doubles
{
	class _Lab_02_Multiply_array_doubles
	{
		static void Main(string[] args)
		{
			double[] arr = Console.ReadLine()
						.Split(' ')
						.Select(double.Parse)
						.ToArray();

			double p = double.Parse(Console.ReadLine());

			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] *= p;
			}

			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i]+" ");
			}
			Console.WriteLine();
		}
	}
}
