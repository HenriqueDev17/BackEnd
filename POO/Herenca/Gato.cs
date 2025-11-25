using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Herenca
{
    public class Gato : Animal
    {
        public override void Fazersom()
        {
             Console.WriteLine("---------------------");
             Console.WriteLine($"         Gato       ");
             Console.WriteLine($"miau miau miau miau ");
             Console.WriteLine("---------------------");
        }
    }
}