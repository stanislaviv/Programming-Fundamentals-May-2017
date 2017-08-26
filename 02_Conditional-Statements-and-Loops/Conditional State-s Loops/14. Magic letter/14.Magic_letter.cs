using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Magic_letter
{
	class Program
	{
		static void Main(string[] args)
		{
			char start = char.Parse(Console.ReadLine());
			char end = char.Parse(Console.ReadLine());
			char invalid_letter = char.Parse(Console.ReadLine());

			int combinations = 0;

			for (char i = start; i <= end; i++)
			{
				for (char j = start; j <= end; j++)
				{
					for (char k = start; k <= end; k++)
					{


						if (i == invalid_letter || k == invalid_letter || j == invalid_letter)
						{
							continue;
						}


						Console.Write("{0}{1}{2} ", i, j, k);
						combinations++;


					}
				}
			}
			Console.WriteLine(combinations);
		}
	}
}
