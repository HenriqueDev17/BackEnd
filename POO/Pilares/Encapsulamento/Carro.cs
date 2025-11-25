using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class Carro
    {
    private string Marca;
    private string Modelo;
    private int VelocidadeAtual;


        //GETS E SETS
        public void DefinirMarca(string valor)
        {
            Marca = valor;
        }

        //get da marca
        public string ObterMarca()
        {
            return Marca;
        }
        //set do modelo
        public void DefinirModelo(string valor)
        {
            Modelo = valor;
        }

        //get do modelo
        public string ObterModelo()
        {
            return Modelo;
        }

            //get da velocidade
            public int ObterVelocidade()
        {
            return VelocidadeAtual;
        }

        //set da velocidade

        public void Acelera(int valor)
        {
            if(valor > 0)
            VelocidadeAtual += valor;
        }
        
        public void Frear(int valor)
        {
            if(valor > 0)
            VelocidadeAtual -= valor;
        }
        
    }


}