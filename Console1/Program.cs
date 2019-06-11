using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    class Program
    {
        static void Main(string[] args)
        {

            var c = new SportCar { Name = "Camry" };
            Console.WriteLine(c);
            c.Move();
            c.MakeNoise();

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
