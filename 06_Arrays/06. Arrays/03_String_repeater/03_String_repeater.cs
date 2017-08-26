using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_String_repeater
{
	class Program
	{
		static void Main(string[] args)
		{
			string inputString = Console.ReadLine();
			int repeatCount = int.Parse(Console.ReadLine());

			string outputString = RepeatString(inputString, repeatCount);
			Console.WriteLine(outputString);

			
		}

		static string RepeatString(string str, int count)
		{
			string repeatedString = string.Empty;

			for (int i = 0; i < count; i++)
			{
				repeatedString += str;
			}
			return repeatedString;
		}
	}
}
