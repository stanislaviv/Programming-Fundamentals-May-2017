using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lab.II._01.Triangle_area
{
	class Program
	{
		static void Main(string[] args)
		{
			double width = double.Parse(Console.ReadLine());
			double height = double.Parse(Console.ReadLine());
			double area = GetTriangleArea(width, height);
			Console.WriteLine(area);

		}

		static double GetTriangleArea(double input_width, double input_height)
		{
			return input_width * input_height / 2;
		}
	}
}
