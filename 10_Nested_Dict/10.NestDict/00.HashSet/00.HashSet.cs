using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.HashSet
{
	class Program
	{
		static void Main(string[] args)
		{
			HashSet<int> set = new HashSet<int>();   //same as list,keep order,daster add ,delete and search. 
													// no indexes in hash set  = not saved in same place as list

			set.Add(5);
			set.Add(10);
			set.Add(3);
			set.Add(15);
			set.Add(25);

			foreach (var number in set)
			{
				Console.WriteLine(number);
			}
		}
	}
}
