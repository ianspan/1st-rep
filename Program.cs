using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double sugar = double.Parse(Console.ReadLine());

            double kal = volume * energy / 100;
            double sug = volume / 100 * sugar;


            Console.WriteLine("{0}ml {1}:", volume, name);
            Console.WriteLine("{0}kcal, {1}g sugars", kal, sug);
        }
    }
}
