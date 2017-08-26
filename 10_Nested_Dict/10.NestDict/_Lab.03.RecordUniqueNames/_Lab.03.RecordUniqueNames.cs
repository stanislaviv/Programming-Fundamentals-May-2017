using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lab._03.RecordUniqueNames
{
	class Program
	{
		static void Main(string[] args)
		{
			HashSet<string> names = new HashSet<string>();

			int inputCnt = int.Parse(Console.ReadLine());

			for (int cnt = 0; cnt < inputCnt; cnt++)
			{
				string name = Console.ReadLine();

				if (!names.Contains(name))
				{
					names.Add(name);
				}
			}
			Console.WriteLine(string.Join("\n",names));
			//Console.WriteLine(string.Join(Environment.NewLine, names));
		}
	}
}
