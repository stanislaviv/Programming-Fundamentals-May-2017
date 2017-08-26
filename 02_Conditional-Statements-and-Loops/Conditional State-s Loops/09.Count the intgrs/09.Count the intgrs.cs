using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Count_the_intgrs
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();
			int number;
			int count = 0;
			


			while (int.TryParse(input, out number))
			{
				input = Console.ReadLine();
				count++;
				
			}

			Console.WriteLine(count);
		}
	}
}
