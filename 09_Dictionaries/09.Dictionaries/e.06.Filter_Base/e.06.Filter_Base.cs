using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e._06.Filter_Base
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, int> employeesAge = new Dictionary<string, int>();
			Dictionary<string, double> employeesSalaries = new Dictionary<string, double>();
			Dictionary<string, string> employeesPositions = new Dictionary<string, string>();

			string[] tokens = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

			while (tokens[0] != "filter")
			{
				string name = tokens[0];
				string value = tokens[1];

				int age;
				double salary;

				if (int.TryParse(value, out age))
				{
					employeesAge[name] = age;
				}
				else if (double.TryParse(value, out salary))
				{
					employeesSalaries[name] = salary;
				}
				else
				{
					employeesPositions[name] = value;  
				}

				tokens = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
			}

			string condition = Console.ReadLine().ToLower();

			if (condition == "position")
			{
				foreach (KeyValuePair<string, string> employee in employeesPositions)
				{
					Console.WriteLine($"Name: {employee.Key}");
					Console.WriteLine($"Position: {employee.Value}");
					Console.WriteLine(new string('=', 20));
				}
			}
			else if (condition == "age")
			{
				foreach (KeyValuePair<string, int> employee in employeesAge)
				{
					Console.WriteLine($"Name: {employee.Key}");
					Console.WriteLine($"Age: {employee.Value}");
					Console.WriteLine(new string('=', 20));
				}
			}
			else
			{
				foreach (KeyValuePair<string, double> employee in employeesSalaries)
				{
					Console.WriteLine($"Name: {employee.Key}");
					Console.WriteLine($"Salary: {employee.Value:f2}");
					Console.WriteLine(new string('=', 20));
				}
			}
		}
	}
}
