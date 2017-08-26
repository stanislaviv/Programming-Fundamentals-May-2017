	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	namespace _02.Vapor_store
	{
		class Program
		{
			static void Main(string[] args)
			{
				double balance = double.Parse(Console.ReadLine());

				double OutFall_4 = 39.99;
				double CS_OG = 15.99;
				double Zplinter_Cell = 19.99;
				double Honored_2 = 59.99;
				double Rover_Watch = 29.99;
				double Rover_Watch_origin = 39.99;

				string input = Console.ReadLine();
				var starting_money = balance;


				while (input != "Game Time")
				{
					double price = 0;
					string currentGame = " ";

					if (input == "OutFall 4")
					{
						currentGame = "OutFall 4";
						price = OutFall_4;
					}
					else if (input == "CS: OG")
					{
						currentGame = "CS: OG";
						price = CS_OG;
					}
					else if (input == "Zplinter Zell")
					{
						currentGame = "Zplinter Zell";
						price = Zplinter_Cell;
					}
					else if (input == "Honored 2")
					{
						currentGame = "Honored 2";
						price = Honored_2;
					}
					else if (input == "RoverWatch")
					{
						currentGame = "RoverWatch";
						price = Rover_Watch;
					}
					else if (input == "RoverWatch Origins Edition")
					{
						currentGame = "RoverWatch Origins Edition";
						price = Rover_Watch_origin;
					}
					else
					{
						Console.WriteLine("Not Found");
						input = Console.ReadLine();
						continue;
					}

					if (price <= balance)
					{
						Console.WriteLine($"Bought {currentGame}");
						balance -= price;
					}
					else
					{
						Console.WriteLine("Too Expensive");

					}

					if (balance <= 0)
					{
						Console.WriteLine("Out of money!");
						return;
					}



					input = Console.ReadLine();
				}

				Console.WriteLine($"Total spent: ${starting_money - balance:f2}. Remaining: ${balance:f2}");

			}
		}
	}
