using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces1
{
    internal class Pelican : ICanFish, IHaveFeathers
    {
        new string bird = "Pelican";

        public void Fish()
        {
            Console.WriteLine($"This {bird} can fish");
        }

        public void CleanFeathers()
        {
            Console.WriteLine($"This {bird} clean the feathers");
        }
    }
}
