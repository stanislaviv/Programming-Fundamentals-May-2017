using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace e._05.SoftUniMessages
{
	class Program
	{
		static void Main(string[] args)
		{
			Regex messagePattern = new Regex(@"^\d+(?<message>[A-Za-z]+)[^a-zA-Z]$");

			string input = Console.ReadLine();

			while (input != "Decrypt!")
			{
				int validMessageLenght = int.Parse(Console.ReadLine());

				if (messagePattern.IsMatch(input))
				{
					Match m = messagePattern.Match(input);
					string message = m.Groups["message"].Value;

					if (message.Length == validMessageLenght)
					{
						string decodedMessage = DecodeMessage(input, message);

						Console.WriteLine("{0} = {1}",message,decodedMessage);
					}
				}

				input = Console.ReadLine();
			}

		}

		static string DecodeMessage(string input, string message)
		{
			string result = "";
			foreach (char symbol in input)
			{
				int index = symbol - '0';
				if (char.IsDigit(symbol)&&index<message.Length)
				{
					result += message[symbol-'0'];
				}
			}

			return result;
		}
	}
}

	
