using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace I._02.Hornet_Comm_RegEx
{
	class Program
	{
		static void Main(string[] args)
		{
			var messagePattern = @"^([0-9]+) <-> ([a-zA-Z0-9]+)$";
			var broadcastPattern = @"^([^0-9]+) <-> ([a-zA-Z0-9]+)$";

			Regex messageRegex = new Regex(messagePattern);
			Regex broadcastRegex = new Regex(broadcastPattern);

			List<string> messages = new List<string>();
			List<string> broadcasts = new List<string>();

			string inputLine = Console.ReadLine();

			while (inputLine != "Hornet is Green")
			{


				if (messageRegex.IsMatch(inputLine))
				{

					Match match = messageRegex.Match(inputLine);
					//NOTICE HOW WE USE THE GROUPS FROM THE REGEX TO EXTRACT THE 2 QUERIES
					//TAKE THE FIRST QUERY, REVERSE THE STRING => IT TURNS INTO A COLLECTION OF CHARACTER "char"
					//THEN STRING JOIN IT BY NOTHING "", AND IT TURNS INTO A STRING (CLEVER EYH)
					string recipientCode = string.Join("", match.Groups[1].Value.Reverse());

					string message = match.Groups[2].Value;

					messages.Add(recipientCode + " -> " + message);
				}

				if (broadcastRegex.IsMatch(inputLine))
				{
					Match match = broadcastRegex.Match(inputLine);

					string message = match.Groups[1].Value;

					string frequency = DecryptFrequency(match.Groups[2].Value);

					broadcasts.Add(frequency + " -> " + message);
				}

				inputLine = Console.ReadLine();
			}

			//PRINT BROADCASTS
			Console.WriteLine("Broadcasts:");
			if (broadcasts.Count > 0)
			{
				Console.WriteLine(string.Join("\n", broadcasts));
			}
			else
			{
				Console.WriteLine("None");
			}

			//THE COOL WAY - WITH LINQ AND TERNARY OPERATOR
			//Console.WriteLine(broadcasts.Any() ? string.Join("\n", broadcasts) : "None");

			//PRINT MESSAGES
			Console.WriteLine("Messages:");
			if (messages.Count > 0)
			{
				Console.WriteLine(string.Join("\n", messages));
			}
			else
			{
				Console.WriteLine("None");
			}

			//THE COOL WAY - WITH LINQ AND TERNARY OPERATOR
			//Console.WriteLine(messages.Any() ? string.Join("\n", messages) : "None");
		}


		private static string DecryptFrequency(string rightPart)
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
