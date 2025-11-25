using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
        public class Pessoa : Animal
   {
       
        public override void Fazersom()
        {
            Console.WriteLine($"Olá, eu sou uma Pessoa");
        }
        public override void Mover()
        {
            Console.WriteLine($"Estou andando a 2km por hora");
        }
   }  
}     