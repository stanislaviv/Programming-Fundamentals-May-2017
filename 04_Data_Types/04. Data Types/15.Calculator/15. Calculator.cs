using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Calculator
{
	class Program
	{
		static void Main(string[] args)
		{
			int firstOperand = int.Parse(Console.ReadLine());
			char operatorChar = char.Parse(Console.ReadLine());
			int secondOperand = int.Parse(Console.ReadLine());

			int result = 0;
			switch (operatorChar)
			{
				case '+':
					result = firstOperand + secondOperand;
					break;
				case '-':
					result = firstOperand - secondOperand;
					break;
				case '*':
					result = firstOperand * secondOperand;
					break;
				case '/':
					result = firstOperand / secondOperand;
					break;
				default:
					break;
			}
			Console.WriteLine($"{firstOperand} {operatorChar} {secondOperand} = {result}");
		}
	}
}
