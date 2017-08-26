using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Trainegram
{
	class Program
	{
		static void Main(string[] args)
		{
			Regex patternLocomotive = new Regex(@"(^\<\[[^a-zA-Z0-9.]+\.){1}(?<wagon>\.\[[a-zA-z0-9]+\.)*$");

			string input = Console.ReadLine();

			var validLocomotives = new List<string>();


			while (input != "Traincode!")
			{
				if (patternLocomotive.IsMatch(input))
				{
					validLocomotives.Add(input);
				}


				input = Console.ReadLine();
			}

			Console.WriteLine(string.Join(Environment.NewLine, validLocomotives));


		}
	}
}
