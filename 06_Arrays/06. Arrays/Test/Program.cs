using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	class Program
	{
		static void Main(string[] args)
		{

			string[] inputName = Console.ReadLine().Split();
			for (int i = 0; i < inputName.Length; i++)
			{
				Console.Write(inputName[i]);
			}
		}
	}
}
