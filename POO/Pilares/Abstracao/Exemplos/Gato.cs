using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public class Gato : Animal
    {
        public override void Fazersom()
        {
            Console.WriteLine($"Gatinho Miau Miau :)");
        }

        public override void Mover()
        {
            Console.WriteLine($"Movendo as patinhas");
        }
    }
}