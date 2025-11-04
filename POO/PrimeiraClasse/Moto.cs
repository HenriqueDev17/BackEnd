using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiraClasse
{
    public class Moto
    {
        public int qtdRodas;
        public string marca = "";
        public string modelo = "";
        public string cor = "";

        //metodos
        public void Ligar()
        {
            Console.WriteLine($"Vrum, Vrum ...");
        }
        public void Desligar()
        {
            Console.WriteLine($"Desligando a moto");
        }
        public void Acelerar()
        {
            Console.WriteLine($"Vruuuuuuuuum tu tu tu tu tu");
        }

    }
}