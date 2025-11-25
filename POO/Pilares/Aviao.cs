using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheBasics
{
    public class Aviao
    {
        
        public string marca;

        public string modelo;

        public int QtdTurbina;

        public void ligar()
        {
            Console.WriteLine($"Ligando o Aviao");
        }
        public void Desligar()
        {
            Console.WriteLine($"Desligando o Aviao");
        }
    }
}