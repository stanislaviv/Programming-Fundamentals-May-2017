using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z._01.Last_3_cosec_equal_ARRAYS_MORE
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] stringArray = Console.ReadLine().Split(' ').ToArray();

			for (int i = stringArray.Length - 1; i >= 2; i--)
			{
				if (stringArray[i] == stringArray[i - 1] && stringArray[i - 1] == stringArray[i - 2])
				{
					Console.WriteLine("{0} {0} {0}",stringArray[i-2]);
					return;
				}
			}
		}
	}
}
