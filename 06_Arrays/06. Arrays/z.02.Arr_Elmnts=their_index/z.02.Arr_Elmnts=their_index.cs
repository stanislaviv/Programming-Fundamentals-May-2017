using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z._02.Arr_Elmnts_their_index
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] intArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			for (int i = 0; i < intArray.Length; i++)
			{
				if (i == intArray[i])
				{
					Console.Write(intArray[i]+" ");
				}
			}
		
		}
	}
}
