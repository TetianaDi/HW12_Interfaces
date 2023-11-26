using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces1
{
    internal class Ostrich : IRunFast
    {
        public void Run()
        {
            Console.WriteLine($"This bird can run fast");
        }
    }
}
