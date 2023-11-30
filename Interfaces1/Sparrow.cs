using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces1
{
    internal class Sparrow : ICanSing, IHaveFeathers
    {
        new string bird = "Sparrow";

        public void Sing()
        {
            Console.WriteLine($"This {bird} can sing");
        }

        public void CleanFeathers()
        {
            Console.WriteLine($"This {bird} clean the feathers");
        }
    }
}
