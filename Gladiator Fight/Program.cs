using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gladiator_Fight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            float health1 = random.Next(90,110);
            int damage1 = random.Next(7, 35);
            int armor1= random.Next(45,100);

            float health2= random.Next(80,120);
            int damage2= random.Next(5,40);
            int armor2= random.Next(65,100);

            Console.WriteLine("Характиристики Гладиаторов: ");
            Console.WriteLine($"Гладиатор 1 - {health1} здоровья, {damage1} наносимый урон, {armor1} броня.");
            Console.WriteLine($"Гладиатор 2 - {health2} здоровья, {damage2} наносимый урон, {armor2} броня.");

            Console.WriteLine("Бой: ");
            while (health1 > 0 && health2 > 0)
            {
                health1 -= Convert.ToSingle(random.Next(0, damage2 + 1)) / 100 * armor1;
                health2 -= Convert.ToSingle(random.Next(0, damage1 + 1)) / 100 * armor2;

                Console.WriteLine($"Здоровье гладиатора 1: {health1}");
                Console.WriteLine($"Здоровье гладиатора 2: {health2}");
            }

            if (health1 <= 0 && health2 <= 0)
                Console.WriteLine("Ничья. Оба гладиатора погибли.");
            else if (health1 >= 0)
                Console.WriteLine("Победил Гладиатор 1. Гладиатор 2 пал");
            else Console.WriteLine("Победил Гладиатор 2. Гладиатор 1 пал");

            Console.ReadKey();
        }
    }
}
