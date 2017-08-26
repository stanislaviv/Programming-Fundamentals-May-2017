using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.LectureSamples_
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, string> phonebook = new Dictionary<string, string>();
			phonebook["Pesho"] = "+1124116565";
			phonebook["Gosho"] = "+11244767565";
			phonebook["Pesho"] = "+999999999999";

			//phonebook.Add("Pesho", "11111111111");

			Console.WriteLine(phonebook.ContainsKey("Pesho"));
			if (phonebook.ContainsKey("Pesho"))
			{
				Console.WriteLine(phonebook["Pesho"]);
			}

			phonebook.Remove("Pesho");
			Console.WriteLine(phonebook.ContainsKey("Pesho"));

			phonebook["Pesho"] = "";

			foreach (KeyValuePair<string, string> item in phonebook)
			{
				if (item.Value != "")
				{
					Console.WriteLine($"{item.Key} ==> {item.Value}" );
				}
			}






		}
	}
}
