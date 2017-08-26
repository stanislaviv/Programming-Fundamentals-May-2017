using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.X
{
	class X
	{
		static void Main(string[] args)
		{
			var height = int.Parse(Console.ReadLine());

			var dots_inside = height - 2;
			var dots_left = 0;

			for (int i = 0; i < height / 2; i++)
			{
				Console.WriteLine("{0}{1}{2}{1}", new string(' ', dots_left), "x", new string(' ', dots_inside));
				dots_left++;
				dots_inside -= 2;
			}
			Console.WriteLine(new string(' ', height / 2) + "x");

			var dots_inside2 = 1;
			var dots_left2 = height / 2 - 1;

			for (int i = 0; i < height / 2; i++)
			{
				Console.WriteLine("{0}{1}{2}{1}", new string(' ', dots_left2), "x", new string(' ', dots_inside2));
				dots_left2--;
				dots_inside2 += 2;
			}
		}
	}
}