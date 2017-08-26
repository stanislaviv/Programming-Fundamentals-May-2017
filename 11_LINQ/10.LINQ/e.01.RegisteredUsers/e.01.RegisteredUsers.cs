using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e._01.RegisteredUsers
{
	class Program
	{
		class Record
		{
			public int Id;
			public DateTime date;

			public Record(int Id, DateTime date)
			{
				this.Id = Id;
				this.date = date;
			}
		}

		static void Main(string[] args)
		{
			string input = Console.ReadLine();

			var data = new Dictionary<string, Record>();
			int Id = 0;

			while (input != "end")
			{
				string[] inputTokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

				string name = inputTokens[0];
				DateTime date = DateTime.ParseExact(inputTokens[1], "dd/mm/yyyy", null);

				data.Add(name, new Record(Id++, date));

				input = Console.ReadLine();
			}

			var orderedData = data
				.OrderBy(r => r.Value.date)
				.ThenByDescending(r => r.Value.Id)
				.Take(5)
				.OrderByDescending(r => r.Value.date);

			foreach (var record in orderedData)
			{
				Console.WriteLine(record.Key);
			}
		}
	}
}
