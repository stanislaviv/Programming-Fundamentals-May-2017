using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Data_Overflow
{
	class Program
	{
		static void Main(string[] args)
		{
			ulong num1 = ulong.Parse(Console.ReadLine());
			ulong num2 = ulong.Parse(Console.ReadLine());

			string typeNum1 = string.Empty;
			string typeNum2 = string.Empty;

			double overflowCount = 0.0;

			bool num1Byte = (byte.MinValue <= num1 && byte.MaxValue >= num1);
			bool num1Ushort = (ushort.MinValue <= num1 && ushort.MaxValue >= num1);
			bool num1Uint = (uint.MinValue <= num1 && uint.MaxValue >= num1);
			bool num1Ulong = (ulong.MinValue <= num1 && ulong.MaxValue >= num1);

			bool num2Byte = (byte.MinValue <= num2 && byte.MaxValue >= num2);
			bool num2Ushort = (ushort.MinValue <= num2 && ushort.MaxValue >= num2);
			bool num2Uint = (uint.MinValue <= num2 && uint.MaxValue >= num2);
			bool num2Ulong = (ulong.MinValue <= num2 && ulong.MaxValue >= num2);

			if (num1Byte)
			{
				typeNum1 = "byte";
			}
			else if (num1Ushort)
			{
				typeNum1 = "ushort";
			}
			else if (num1Uint)
			{
				typeNum1 = "uint";
			}
			else
			{
				typeNum1 = "ulong";
			}


			if (num2Byte)
			{
				typeNum2 = "byte";
			}
			else if (num2Ushort)
			{
				typeNum2 = "ushort";
			}
			else if (num2Uint)
			{
				typeNum2 = "uint";
			}
			else
			{
				typeNum2 = "ulong";
			}

			if (num1 > num2)
			{
				Console.WriteLine($"bigger type: {typeNum1}");
				Console.WriteLine($"smaller type: {typeNum2}");

				if (typeNum1=="ulong")
				{
					if (typeNum2=="uint")
					{
						overflowCount = (num1 / (double)uint.MaxValue);
					}
					else if (typeNum2=="ushort")
					{
						overflowCount = (num1 / (double)ushort.MaxValue);
					}
					else if (typeNum2=="byte")
					{
						overflowCount = (num1 / (double)byte.MaxValue);
					}
				}
				else if (typeNum1=="uint")
				{
					if (typeNum2 == "ushort")
					{
						overflowCount = (num1 / (double)ushort.MaxValue);
					}
					else if (typeNum2 == "byte")
					{
						overflowCount = (num1 / (double)byte.MaxValue);
					}
				}
				else if (typeNum1=="ushort")
				{
					if (typeNum2=="byte")
					{
						overflowCount = (num1 / (double)byte.MaxValue);
					}
				}

				Console.WriteLine($"{num1} can overflow {typeNum2} {Math.Round(overflowCount)} times");
			}
			else
			{
				Console.WriteLine($"bigger type: {typeNum2}");
				Console.WriteLine($"smaller type: {typeNum1}");

				if (typeNum2 == "ulong")
				{
					if (typeNum1 == "uint")
					{
						overflowCount = (num2 / (double)uint.MaxValue);
					}
					else if (typeNum1 == "ushort")
					{
						overflowCount = (num2 / (double)ushort.MaxValue);
					}
					else if (typeNum1 == "byte")
					{
						overflowCount = (num2 / (double)byte.MaxValue);
					}
				}
				else if (typeNum2 == "uint")
				{
					if (typeNum1 == "ushort")
					{
						overflowCount = (num2 / (double)ushort.MaxValue);
					}
					else if (typeNum1 == "byte")
					{
						overflowCount = (num2 / (double)byte.MaxValue);
					}
				}
				else if (typeNum2 == "ushort")
				{
					if (typeNum1 == "byte")
					{
						overflowCount = (num2 / (double)byte.MaxValue);
					}
				}
				Console.WriteLine($"{num2} can overflow {typeNum1} {Math.Round(overflowCount)} times");
			}

	


		}
	}
}
