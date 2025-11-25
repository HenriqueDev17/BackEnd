using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Herenca
{
    public class Cachorro : Animal
    {
        public override void Fazersom()
        {
             Console.WriteLine("------------");
             Console.WriteLine($" Cachorro  ");
             Console.WriteLine($"au au au au");
             Console.WriteLine("------------");

        }
    }
}