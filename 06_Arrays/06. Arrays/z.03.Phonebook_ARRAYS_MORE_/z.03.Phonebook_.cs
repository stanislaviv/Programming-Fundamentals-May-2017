using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z._03.Phonebook_ARRAYS_MORE_
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] Phones = Console.ReadLine().Split(' ').ToArray();
			string[] Names = Console.ReadLine().Split(' ').ToArray();
			string inputName = string.Empty;

			while (inputName != "done")
			{
				for (int i = 0; i < Names.Length; i++)
				{
					if (inputName == Names[i])
					{
						Console.WriteLine("{0} -> {1}", Names[i], Phones[i]);
						break;
					}
				}
				inputName = Console.ReadLine();

			}


			
		}
	}
}
