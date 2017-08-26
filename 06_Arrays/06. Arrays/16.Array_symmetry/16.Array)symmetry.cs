using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Array_symmetry
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] stringArray = Console.ReadLine().Split(' ');
			bool isSymmetric = false;
			int n = stringArray.Length / 2;
			for (int i = 0; i < n; i++)
			{
				if (stringArray[i] == stringArray[stringArray.Length - 1 - i])
				{
					isSymmetric = true;
				}
				else
				{
					isSymmetric = false;
					break;
				}
			}
			if (isSymmetric)
			{
				Console.WriteLine("Yes");
			}
			else
			{
				Console.WriteLine("No");
			}
		}
	}
}
