using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.From_Terabytes_to_Bits
{
	class Program
	{
		static void Main(string[] args)
		{
			decimal TB = decimal.Parse(Console.ReadLine());
			decimal TB_to_bit = TB * 8 * 1024 * 1024 * 1024 * 1024;

			Console.WriteLine(Math.Round(TB_to_bit));



		}
	}
}
