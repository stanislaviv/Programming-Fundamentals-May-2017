using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Trainlands
{
	class Program
	{
		static void Main(string[] args)
		{
			var trains = new Dictionary<string, Dictionary<string, int>>();

			string[] inputTokens = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

			while (inputTokens[0] != "It's Training Men!")
			{
				string trainName = inputTokens[1];
				string[] wagonnData = inputTokens[1].Split(new string[] { " : " }, StringSplitOptions.RemoveEmptyEntries);
				string wagonName = wagonnData[0];
				int power = int.Parse(wagonnData[1]);

				if (!trains.ContainsKey(wagonName))
				{
					trains[trainName] = new Dictionary<string, int>();
				}

				if (!trains[trainName].ContainsKey(wagonName))
				{
					trains[trainName][wagonName] = power;
				}
				



				inputTokens = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
			}
		}
	}
}
