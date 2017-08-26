using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _More_01.Distinct_List
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

			List<int> distinct = numbers.Distinct().ToList();
			Console.WriteLine(string.Join(" ",distinct));
		}
	}
}
