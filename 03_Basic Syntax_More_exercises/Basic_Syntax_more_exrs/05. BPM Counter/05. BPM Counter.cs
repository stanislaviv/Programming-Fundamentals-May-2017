using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BPM_Counter
{
	class Program
	{
		static void Main(string[] args)
		{
			double BPM = double.Parse(Console.ReadLine());
			double nr_beats = double.Parse(Console.ReadLine());

			int minutes = 0;
			int seconds = 0;
			double bars = Math.Round((nr_beats / 4), 1);
			double beats_per_second = BPM / 60;

			seconds = (int)(nr_beats / beats_per_second);

			if (seconds<60)
			{
				seconds = seconds % 60;
			}
			else
			{
				minutes = seconds / 60;
				seconds = seconds - (minutes * 60);
			}

			Console.WriteLine($"{bars} bars - {minutes}m {seconds}s" );


		}
	}
}
