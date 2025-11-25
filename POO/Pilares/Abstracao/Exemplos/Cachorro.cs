using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public class Cachorro : Animal
    {
        public override void Fazersom()
        {
            Console.WriteLine($"Au Au");
        }

        public override void Mover()
        {
            Console.WriteLine($"Ploc Ploc Ploc");
        }
    }
}