using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Calories_Counter
{
	class Program
	{
		static void Main(string[] args)
		{
			var cheese_count = 0;
			var tomato_sauce_count = 0;
			var salami_count = 0;
			var pepper_count = 0;

			var n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				string ingredient = Console.ReadLine().ToLower();
				if (ingredient == "cheese")
				{
					cheese_count++;
				}
				else if (ingredient == "tomato sauce")
				{
					tomato_sauce_count++;
				}
				else if (ingredient == "salami")
				{
					salami_count++;
				}
				else if (ingredient == "pepper")
				{
					pepper_count++;
				}

				
			}
			var total_calories = cheese_count * 500 + tomato_sauce_count * 150 + salami_count * 600 + pepper_count * 50;
			Console.WriteLine($"Total calories: {total_calories}");

		}
	}
}
