using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterStats
{
    class program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            int currhealth = int.Parse(Console.ReadLine());
            int allhealth = int.Parse(Console.ReadLine());
            int currenergy = int.Parse(Console.ReadLine());
            int allenergy = int.Parse(Console.ReadLine());

            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Health: |{0}{1}|", new string('|', currhealth), 
                                                  new string('.', allhealth - currhealth));
            Console.WriteLine("Energy: |{0}{1}|", new string('|', currenergy), 
                                                  new string('.', allenergy - currenergy));
        }
    }
}
