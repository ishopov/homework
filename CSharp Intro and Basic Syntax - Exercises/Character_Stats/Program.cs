using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var currentHealth = int.Parse(Console.ReadLine());
            var maxHealth = int.Parse(Console.ReadLine());
            var currentEnergy = int.Parse(Console.ReadLine());
            var maxEnergy = int.Parse(Console.ReadLine());



            Console.WriteLine($"Name: {name}"); ;

            Console.Write($"Health: ");
            Console.Write(new string('|', currentHealth + 1));
            Console.Write(new string('.', maxHealth - currentHealth));
            Console.WriteLine("|");

            Console.Write($"Energy: ");
            Console.Write(new string('|', currentEnergy + 1));
            Console.Write(new string('.', maxEnergy-currentEnergy));
            Console.WriteLine("|");
        }
    }
}
