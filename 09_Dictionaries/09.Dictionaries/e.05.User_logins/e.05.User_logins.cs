using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e._05.User_logins
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, string> usersCredentials = new Dictionary<string, string>();

			string[] input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

			while (input[0] != "login")
			{
				string userName = input[0];
				string password = input[1];

				usersCredentials[userName] = password;

				input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
			}

			input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

			int failed = 0;
			while (input[0] != "end")
			{
				string userName = input[0];
				string password = input[1];

				if (!usersCredentials.ContainsKey(userName) || usersCredentials[userName] != password)
				{
					Console.WriteLine($"{userName}: login failed");
					failed++;
				}
				else
				{
					Console.WriteLine($"{userName}: logged in successfully");
				}

				input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

			}
			Console.WriteLine($"unsuccessful login attempts: {failed}");
		}
	}
}
