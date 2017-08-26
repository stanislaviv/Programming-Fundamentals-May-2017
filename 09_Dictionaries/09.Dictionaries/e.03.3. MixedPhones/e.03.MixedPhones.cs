using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e._03._3.MixedPhones
{
	class Program
	{
		static void Main(string[] args)
		{
			SortedDictionary<string, decimal> NamedPhones = new SortedDictionary<string, decimal>();


			string[] tokens = Console.ReadLine().Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);

			while (tokens[0] != "Over")
			{
				string firstInput = tokens[0];
				string secondInput = tokens[1];

				decimal phone = 0m;

				if (decimal.TryParse(firstInput, out phone))
				{
					NamedPhones[secondInput] = phone;
				}
				else if (decimal.TryParse(secondInput, out phone))
				{
					NamedPhones[firstInput] = phone;
				}


				tokens = Console.ReadLine().Split(new char[] { ' ', ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);
			}

			foreach (KeyValuePair<string, decimal> entry in NamedPhones)
			{
				Console.WriteLine($"{entry.Key} -> {entry.Value}");
			}


		}
	}
}
