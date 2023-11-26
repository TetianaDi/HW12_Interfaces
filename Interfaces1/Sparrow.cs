using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces1
{
    internal class Sparrow : ICanSing
    {
        public void Sing()
        {
            Console.WriteLine($"This bird can sing");
        }
    }
}
