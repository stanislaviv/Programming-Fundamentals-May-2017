using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _Lab._02.MatchPhoneNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			var regex = @"\+359(-| )2\1(\d{3})\1(\d{4})\b";
			var phones = Console.ReadLine();

			MatchCollection phoneMatches = Regex.Matches(phones, regex);

			//var numbers = phoneMatches.Cast<Match>().Select(a => a.Value).ToArray();
			//Console.WriteLine(string.Join(", ", numbers));


			StringBuilder builder = new StringBuilder();
			foreach (Match phone in phoneMatches)
			{
				builder.Append(phone.Value + ", ");
			}

			builder.Remove(builder.Length - 2, 2);
			Console.WriteLine(builder.ToString());



		}
	}
}
