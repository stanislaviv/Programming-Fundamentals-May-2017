using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Notifications
{
	class Program
	{
		static void Main(string[] args)
		{
			int iterations = int.Parse(Console.ReadLine());

			for (int i = 0; i < iterations; i++)
			{
				string result = Console.ReadLine();
				if (result == "success")
				{
					string operation = Console.ReadLine();
					string message = Console.ReadLine();
					string output = ShowSuccess(operation, message);
					Console.WriteLine(output);
				}
				else if (result == "error")
				{
					string operation = Console.ReadLine();
					int code = int.Parse(Console.ReadLine());
					string ouput = ErrorMessage(operation, code);
					Console.WriteLine(ouput);
				}
				else
					continue;
			}

		}



		private static string ShowSuccess(string operation, string message)
		{
			string output = $@"Successfully executed {operation}.
==============================
Message: {message}.";
			return output;
		}

		private static string ErrorMessage(string operation, int code)
		{
			string reason = "Invalid Client Data";

			if (code < 0)
			{
				reason = "Internal System Failure";
			}

			string output = $@"Error: Failed to execute {operation}.
==============================
Error Code: {code}.
Reason: {reason}.";

			return output;
		}
	}
}
