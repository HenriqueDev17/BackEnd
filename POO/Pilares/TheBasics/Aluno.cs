using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace TheBasics
{
    public class Aluno : Pessoa
    {
        //cria um construtor na classe aluno que recebe o endereço
        //chama o construtor da classe mãe (base) e repassa o
        //endereço para ela
        public Aluno(Endereco endereco) : base(endereco)
        {
            EnderecoCompleto = endereco;
        }

        public string RA;
        public float NotaFinal;
        public string Curso;
    }
}