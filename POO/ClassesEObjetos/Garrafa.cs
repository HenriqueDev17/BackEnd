using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesEObjetos
{
    public class Garrafa
    {
        public double Capacidade;
        public string Marca = "";
        public string Cor = "";
        public string Material = "";
        public void Abrindo()
        {
            Console.WriteLine($"Gluk, abrindo a garrafa");
        }

        public void Enchendo()
        {
            Console.WriteLine($"Shiiiiiiiiiiiii");
        }

        public void Bebendo()
        {
            Console.WriteLine($"Glub glub glub......");
        }

        public void Esvaziando()
        {
            Console.WriteLine($"Glu Glu Gluuu......");
        }
        
    }
}