using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var height = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var area = height * width;

            Console.WriteLine($"{area:f2}");


        }
    }
}
