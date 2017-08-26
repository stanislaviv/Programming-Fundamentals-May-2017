using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Photo_Gallery
{
	class Program
	{
		static void Main(string[] args)
		{
			var number = int.Parse(Console.ReadLine());
			var day = int.Parse(Console.ReadLine());
			var month = int.Parse(Console.ReadLine());
			var year = int.Parse(Console.ReadLine());
			var hours = int.Parse(Console.ReadLine());
			var minutes = int.Parse(Console.ReadLine());
			var bytes = double.Parse(Console.ReadLine());
			var width = int.Parse(Console.ReadLine());
			var height = int.Parse(Console.ReadLine());

			string size_unit = " ";
			double size = 0.0;
			string orientation = " ";


			if (bytes < 1000)
			{
				size_unit = "B";
				size = bytes;
			}
			else if (bytes >= 1000 && bytes < 1000000)
			{
				size_unit = "KB";
				size = bytes / 1000;
			}
			else
			{
				size_unit = "MB";
				size = bytes / 1000000;
			}

			if (width == height)
			{
				orientation = "square";
			}

			else if (width > height)
			{
				orientation = "landscape";
			}

			else
			{
				orientation = "portrait";
			}


			Console.WriteLine($"Name: DSC_{number:d4}.jpg");
			Console.WriteLine($"Date Taken: {day:d2}/{month:d2}/{year:d2} {hours:d2}:{minutes:d2}");
			Console.WriteLine($"Size: {Math.Round(size, 1)}{size_unit}");
			Console.WriteLine($"Resolution: {width}x{height} ({orientation})");


		}
	}
}
