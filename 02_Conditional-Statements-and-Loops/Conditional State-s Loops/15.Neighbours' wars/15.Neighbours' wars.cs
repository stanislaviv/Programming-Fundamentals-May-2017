using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Neighbours__wars
{
	class Program
	{
		static void Main(string[] args)
		{
			var Pesho_dmg = int.Parse(Console.ReadLine());
			var Gosho_dmg = int.Parse(Console.ReadLine());

			var Pesho_health = 100;
			var Gosho_health = 100;

			var peshoAbility = "Roundhouse kick";
			var goshoAbility = "Thunderous fist";
			var rounds = 0;

			for (int fight = 1; fight <= 100; fight++)
			{
				if (fight % 2 != 0)
				{
					Gosho_health -= Pesho_dmg;
					if (Gosho_health < 0)
					{
						break;
					}
					else
					{
						Console.WriteLine($"Pesho used {peshoAbility} and reduced Gosho health to {Gosho_health} health.");
					}
				}
				else if (fight % 2 == 0)
				{
					Pesho_health -= Gosho_dmg;
					if (Pesho_health < 0)
					{
						break;
					}
					else
					{
						Console.WriteLine($"Gosho used {goshoAbility} and reduced Pesho health to {Pesho_health} health.");
					}

				}

				if (fight % 3 == 0)
				{
					Gosho_health += 10;
					Pesho_health += 10;
				}
				rounds = fight;

			}
			if (Gosho_health <= 0)
			{
				Console.WriteLine($"Pesho won in {rounds + 1}th round.");
			}
			else if (Pesho_health <= 0)
			{
				Console.WriteLine($"Gosho won in {rounds + 1}th round.");
			}
		}
	}
}
