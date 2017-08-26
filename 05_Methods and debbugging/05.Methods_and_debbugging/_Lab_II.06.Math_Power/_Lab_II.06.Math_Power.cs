using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lab_II._06.Math_Power
{
	class Program
	{
		static void Main(string[] args)
		{
			double number = double.Parse(Console.ReadLine());
			int power = int.Parse(Console.ReadLine());

			Console.WriteLine(RaisePower(number, power));

		}

		static double RaisePower(double input_number, int input_power)
		{
			double result = 1;
			for (int i = 1; i <= input_power; i++)
			{
				result *= input_number;
			}
			return result;
		}
	
	}
}
