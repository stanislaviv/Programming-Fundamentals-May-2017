using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Beverage_labels
{
    class Program
    {
        static void Main(string[] args)
        {
			string name = Console.ReadLine();
            var volume = double.Parse(Console.ReadLine());
            var energy_content = double.Parse(Console.ReadLine());
            var sugar_content = double.Parse(Console.ReadLine());

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energy_content/100*volume}kcal, {sugar_content/100*volume}g sugars");


        }
    }
}
