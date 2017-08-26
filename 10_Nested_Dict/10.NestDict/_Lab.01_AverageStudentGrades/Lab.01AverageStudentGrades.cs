using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lab._01_AverageStudentGrades
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, List<double>> studentsData = new Dictionary<string, List<double>>();

			int inputCnt = int.Parse(Console.ReadLine());

			for (int i = 0; i < inputCnt; i++)
			{
				string[] inputTokens = Console.ReadLine().Split(' ');
				string name = inputTokens[0];
				double grade = double.Parse(inputTokens[1]);

				if (!studentsData.ContainsKey(name))
				{
					List<double> list = new List<double>();
					list.Add(grade);
					studentsData.Add(name, list);
				}
				else
				{
					List<double> studentGrades = studentsData[name];
					studentGrades.Add(grade);

					//studentsData[name].Add(grade);    //shorter version of the 2 lines above - add a list as value to the
					//key which is the student name
				}

				// ANOTHER VERSION  - 
				//if (!studentsData.ContainsKey(name))
				//{
				//	studentsData.Add(name, new List<double>());
				//}
				//studentsData[name].Add(grade);
			}

			foreach (KeyValuePair<string, List<double>> studentData in studentsData)
			{
				string name = studentData.Key;
				List<double> grades = studentData.Value;
				double avr = grades.Average();

				Console.Write("{0} -> ", name);
				foreach (double grade in grades)
				{
					Console.Write("{0:f2} ", grade);
				}

				Console.WriteLine("(avg: {0:f2})",avr);
			}
		}
	}
}

