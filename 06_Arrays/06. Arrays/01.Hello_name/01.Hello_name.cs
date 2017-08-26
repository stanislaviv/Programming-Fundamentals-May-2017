using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Hello_name
{
	class Program
	{
		static void Main(string[] args)
		{
			string nameInput = Console.ReadLine();
			PrintName(nameInput);
		}

		private static void PrintName(string name)
		{
		Console.WriteLine($"Hello, {name}!");
		}
	}
}
