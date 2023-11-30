using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ostrich ostrich = new Ostrich();
            ostrich.Run();
            ostrich.CleanFeathers();

            Sparrow sparrow = new Sparrow();
            sparrow.Sing();
            sparrow.CleanFeathers();

            Pelican pelican = new Pelican();
            pelican.Fish();
            pelican.CleanFeathers();


            Console.ReadLine();
        }
    }
}
