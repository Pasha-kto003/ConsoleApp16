using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Class1
        
        {


            static void Main(string[] args)
            {
                Cat c = new Cat("Vladik", new DateTime(2020, 05, 25));
                c.MakeNoise();
                Console.WriteLine($"Кошка по имени {c.Name} уже {c.GetAge()} лет");
                c.HungryStatus = 150;
                Console.ReadLine();
            }
        }
}
