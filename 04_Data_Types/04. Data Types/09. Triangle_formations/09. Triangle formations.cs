using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Triangle_formations
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
			int c = int.Parse(Console.ReadLine());

			bool check = ((a + b) > c && (a + c) > b && (b + c) > a);
			bool rightAngleAB = a * a + b * b == c * c;
			bool rightAngleAC = a * a + c * c == b * b;
			bool rightAngleBC = b * b + c * c == a * a;


			if (check)
			{
				Console.WriteLine("Triangle is valid.");
				
			}
			else
			{
				Console.WriteLine("Invalid Triangle.");
				return;
			}

			if (rightAngleAB)
			{
				Console.WriteLine("Triangle has a right angle between sides a and b");
			}
			else if (rightAngleAC)
			{
				Console.WriteLine("Triangle has a right angle between sides a and c");
			}
			else if (rightAngleBC)
			{
				Console.WriteLine("Triangle has a right angle between sides b and c");
			}
			else if (check)
			{
				Console.WriteLine("Triangle has no right angles");
			}



			

		}


	}

}
