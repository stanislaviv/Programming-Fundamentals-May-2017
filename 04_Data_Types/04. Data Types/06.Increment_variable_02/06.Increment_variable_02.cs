using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Increment_variable_02
{
	class Program
	{
		static void Main(string[] args)
		{
			long n = long.Parse(Console.ReadLine());
			long remaining = n % (byte.MaxValue + 1);
			long overflowCount = n / (byte.MaxValue + 1);

			Console.WriteLine(remaining);
			Console.WriteLine($"Overflowed {overflowCount} times");
		}
	}
}
