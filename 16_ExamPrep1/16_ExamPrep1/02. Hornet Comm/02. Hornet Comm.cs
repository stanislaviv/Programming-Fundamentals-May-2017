using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Hornet_Comm
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> messages = new List<string>();
			List<string> broadcasts = new List<string>();

			string input = Console.ReadLine();


			while (input != "Hornet is Green")
			{
				string[] tokens = input.Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries);

				if (tokens.Length != 2)
				{
					input = Console.ReadLine();
					tokens = input.Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries);
					continue;
				}
				string leftPart = tokens[0];
				string rightPart = tokens[1];


				if (leftPart.All(char.IsDigit) && rightPart.All(char.IsLetterOrDigit))
				{
					string reversed = new string(leftPart.ToCharArray().Reverse().ToArray());

					messages.Add($"{reversed} -> {rightPart}");
				}
				else if (leftPart.All(c => !char.IsDigit(c)) && rightPart.All(char.IsLetterOrDigit))
				{
					string reversedCases = ReverseCases(rightPart);

					broadcasts.Add($"{reversedCases} -> {leftPart}");
				}

				input = Console.ReadLine();
			}

			Console.WriteLine("Broadcasts:");
			Console.WriteLine(broadcasts.Count == 0 ? "None" : string.Join(Environment.NewLine, broadcasts));

			Console.WriteLine("Messages:");
			Console.WriteLine(messages.Count == 0 ? "None" : string.Join(Environment.NewLine, messages));
		}

		private static string ReverseCases(string rightPart)
		{
			StringBuilder result = new StringBuilder();

			for (int i = 0; i < rightPart.Length; i++)
			{
				if (char.IsUpper(rightPart[i]))
				{
					result.Append(char.ToLower(rightPart[i]));
				}
				else if (char.IsLower(rightPart[i]))
				{
					result.Append(char.ToUpper(rightPart[i]));
				}
				else
				{
					result.Append(rightPart[i]);
				}
			}
			return result.ToString();
		}
	}
}
