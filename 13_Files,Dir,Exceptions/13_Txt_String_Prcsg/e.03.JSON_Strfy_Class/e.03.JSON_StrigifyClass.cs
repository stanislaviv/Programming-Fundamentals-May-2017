using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e._03.JSON_Strfy_Class
{
	class Program
	{
		class Student
		{
			public string Name { get; set; }
			public int Age { get; set; }
			public List<int> Grades { get; set; }

			public Student(string name, int age, List<int> grades)
			{
				this.Name = name;
				this.Age = age;
				this.Grades = grades;

			}
		}

		static void Main(string[] args)
		{
			string inputLine = Console.ReadLine();

			StringBuilder result = new StringBuilder("[");

			List<Student> students = new List<Student>();

			while (inputLine != "stringify")
			{
				string[] tokens = inputLine
				   .Split(new[] { ' ', ',', ':', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

				string name = tokens[0];
				int age = int.Parse(tokens[1]);
				List<int> grades = tokens.Skip(2).Select(int.Parse).ToList();

				Student newStudent = new Student(name, age, grades);
				students.Add(newStudent);

				inputLine = Console.ReadLine();
			}

			for (int i = 0; i < students.Count; i++)
			{
				Student student = students[i];

				result.Append("{name:\"" + student.Name + "\",age:" + student.Age + ",grades:[");
				result.Append(string.Join(", ", student.Grades) + "]}");
				if (i < students.Count - 1)
				{
					result.Append(",");
				}
			}

			result.Append("]");

			Console.WriteLine(result.ToString());
		}


	}
}
