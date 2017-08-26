using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z04.Phone
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] phoneNumbers = Console.ReadLine().Split(' ').ToArray();
			string[] names = Console.ReadLine().Split(' ').ToArray();
			string[] inputName = Console.ReadLine().Split(' ').ToArray();

			while (inputName[0] != "done")
			{
				// First part - if it is a call
				if (inputName[0] == "call")
				{
					for (int i = 0; i < names.Length; i++)
					{
						if (inputName[1] == names[i])   // Run the loop until the input name == name in the []names
														// when the input is Name and not phone
						{
							Console.WriteLine($"calling {phoneNumbers[i]}...");

							string phoneNumber = phoneNumbers[i];
							int sumOfDigits = takeSumOfDigits(phoneNumber);

							if (sumOfDigits % 2 == 1)
							{
								Console.WriteLine("no answer");
							}
							else
							{
								int minutes = sumOfDigits / 60;
								int seconds = sumOfDigits % 60;
								string duration = $"{minutes:d2}:{seconds:d2}";
								Console.WriteLine($"call ended. duration: {duration}");
							}
						}

						if (inputName[1] == phoneNumbers[i])   // Run the loop until the input phone == phone in the []PhoneNumbers
															   // when the input is phone,not name
						{
							Console.WriteLine($"calling {names[i]}...");

							string phoneNumber = phoneNumbers[i];
							int sumOfDigits = takeSumOfDigits(phoneNumber);

							if (sumOfDigits % 2 == 1)
							{
								Console.WriteLine("no answer");
							}
							else
							{
								int minutes = sumOfDigits / 60;
								int seconds = sumOfDigits % 60;
								string duration = $"{minutes:d2}:{seconds:d2}";
								Console.WriteLine($"call ended. duration: {duration}");
							}
						}
					}
				}

				// Second Part  - if it is a message
				if (inputName[0] == "message")
				{
					for (int i = 0; i < names.Length; i++)
					{
						if (inputName[1] == names[i])
						{
							Console.WriteLine($"sending sms to {phoneNumbers[i]}...");

							string phoneNumber = phoneNumbers[i];
							int sumOfDiggits = takeSumOfDigits(phoneNumber);

							if (sumOfDiggits % 2 == 0)
							{
								Console.WriteLine("meet me there");
							}
							else
							{
								Console.WriteLine("busy");
							}
						}
						if (inputName[1] == phoneNumbers[i])
						{
							Console.WriteLine($"sending sms to {names[i]}...");

							string phoneNumber = phoneNumbers[i];
							int sumOfDiggits = takeSumOfDigits(phoneNumber);
							if (sumOfDiggits % 2 == 0)
							{
								Console.WriteLine("meet me there");
							}
							else
							{
								Console.WriteLine("busy");
							}
						}
					}
				}

				inputName = Console.ReadLine().Split(' ');

			}

		}

		private static int takeSumOfDigits(string phoneNumber)
		{
			int sumOfDigits = 0;

			for (int i = 0; i < phoneNumber.Length; i++)
			{
				if (phoneNumber[i] >= 48 && phoneNumber[i] <= 57)
				{
					sumOfDigits += ((int)phoneNumber[i] - 48);
				}
			}

			return sumOfDigits;
		}
	}
}
