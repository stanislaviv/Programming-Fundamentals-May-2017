using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lab_04.Rotate_elements_array
{
	class Program
	{
		static void Main(string[] args)
		{

			//	string[] arr = Console.ReadLine().Split(' ');
			//	string[] arrResult = new string[arr.Length];

			//	for (int i = 0; i < arr.Length - 1; i++)
			//	{
			//		arrResult[i + 1] = arr[i];
			//	}

			//	arrResult[0] = arr[arr.Length - 1];

			//	//2nd version - just for loop

			//	//for (int i = 0; i < arr.Length - 1; i++)
			//	//{
			//	//	arrResult[(i + 1) % arr.Length] = arr[i];
			//	//}

			//	Console.WriteLine(string.Join(" ", arrResult));
			//


			//VERSION WITH ONE ARRAY ONLY
			string[] arr = Console.ReadLine().Split(' ');

			string currentElement = arr[arr.Length - 1];

			for (int i = 0; i < arr.Length; i++)
			{
				string temp = arr[i];
				arr[i] = currentElement;
				currentElement = arr[i];
			}

		}
	}
}
