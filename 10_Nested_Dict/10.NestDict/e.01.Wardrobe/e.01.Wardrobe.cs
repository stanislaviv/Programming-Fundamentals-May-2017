using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e._01.Wardrobe
{
	class Program
	{
		static void Main(string[] args)
		{
			var data = new Dictionary<string, Dictionary<string, int>>();
			int inputCnt = int.Parse(Console.ReadLine());

			for (int i = 0; i < inputCnt; i++)
			{
				string[] inputTokens = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

				string color = inputTokens[0];
				string[] clothes = inputTokens[1].Split(',');

				if (!data.ContainsKey(color))
				{
					data.Add(color, new Dictionary<string, int>());
				}

				foreach (string item in clothes)
				{
					Dictionary<string, int> itemType = data[color];

					if (!itemType.ContainsKey(item))
					{
						itemType.Add(item, 0);
					}
					itemType[item]++;
				}
			}


			string[] searchTokens = Console.ReadLine().Split(' ');
			string searchedColor = searchTokens[0];
			string searchedCloth = searchTokens[1];

			foreach (KeyValuePair<string, Dictionary<string, int>> colorData in data)
			{
				string color = colorData.Key;
				Dictionary<string, int> clothesData = colorData.Value;

				Console.WriteLine("{0} clothes:", color);

				foreach (KeyValuePair<string, int> item in clothesData)
				{
					string clothName = item.Key;
					int quantity = item.Value;

					Console.Write("* {0} - {1}", clothName, quantity);

					if (color == searchedColor && clothName == searchedCloth)
					{
						Console.Write(" (found!) ");
					}
					Console.WriteLine();

				}

			}
		}
	}
}
