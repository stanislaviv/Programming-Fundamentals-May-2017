using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Track_Downloader
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> bannedWords = Console.ReadLine().Split(' ').ToList();

			string song = Console.ReadLine();
			List<string> playlist = new List<string>();
			

			while (song != "end")
			{
				bool isBannedWord = false;

				for (int i = 0; i < bannedWords.Count; i++)
				{
					if (song.Contains(bannedWords[i]))
					{
						isBannedWord = true;
					}
				}

				if (!isBannedWord)
				{
					playlist.Add(song);
				}

				song = Console.ReadLine();

			}

			playlist.Sort();
			Console.WriteLine(string.Join("\r\n",playlist));
		}
	}
}