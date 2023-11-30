using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces1
{
    internal class Ostrich : IRunFast, IHaveFeathers
    {
        new string bird = "Ostrich";

        public void Run()
        {
            Console.WriteLine($"This {bird} can run fast");
        }

        public void CleanFeathers()
        {
            Console.WriteLine($"This {bird} clean the feathers");
        }
    }
}
