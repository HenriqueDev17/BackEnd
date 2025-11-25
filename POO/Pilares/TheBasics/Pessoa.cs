using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheBasics
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;
        public Endereco EnderecoCompleto;

        public Pessoa(Endereco endereco){
            EnderecoCompleto = endereco;
        }
        
        //endereco
        
        public void Falar()
        {
            Console.WriteLine($"Olá, eu sou o {Nome} e tenho {Idade} anos");
        }

        public void Envelhecer()
        {
            Idade++;


        }
    }
}