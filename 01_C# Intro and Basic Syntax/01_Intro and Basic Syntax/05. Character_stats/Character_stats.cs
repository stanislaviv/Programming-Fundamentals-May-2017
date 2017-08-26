using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Character_stats
{
    class Character_stats
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int current_health = int.Parse(Console.ReadLine());
            int max_health = int.Parse(Console.ReadLine());
            int current_energy = int.Parse(Console.ReadLine());
            int max_energy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.Write("Health: ");
            Console.WriteLine("{0}{1}{2}{0}", "|", new string('|',current_health),new string('.',max_health-current_health));
            Console.Write("Energy: ");
            Console.WriteLine("{0}{1}{2}{0}", "|", new string('|', current_energy), new string('.', max_energy - current_energy));

        }
    }
}
