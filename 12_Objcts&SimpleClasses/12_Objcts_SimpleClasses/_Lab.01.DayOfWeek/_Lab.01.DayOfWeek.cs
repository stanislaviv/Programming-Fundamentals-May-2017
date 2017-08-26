using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lab._01.DayOfWeek
{
	class Program
	{
		static void Main(string[] args)
		{
			DateTime inputData = DateTime.ParseExact(
				Console.ReadLine(),
				"d-M-yyyy", 
				CultureInfo.InvariantCulture);

			Console.WriteLine(inputData.DayOfWeek);
		}
	}
}