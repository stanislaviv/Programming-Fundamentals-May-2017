using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lab_05.Triple_letrs
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());	
			for (int cnt1 = 0; cnt1 < n; cnt1++)
			{
				for (int cnt2 = 0; cnt2 < n; cnt2++)
				{
					for (int cnt3 = 0; cnt3 < n; cnt3++)
					{
						Console.WriteLine(" " + 
							(char)(cnt1 + 'a') + 
							(char)(cnt2 + 'a') + 
							(char)(cnt3 + 'a'));
					}
				}
				
			}

		}
	}
}
