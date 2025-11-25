using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class ContaBancaria
    {
        private float Saldo;

//metodo construtor
        public ContaBancaria()
        {
            Saldo = 0;
        }
        public ContaBancaria(float saldoInicial)
        {
            if(saldoInicial > 0)
            {
               Saldo = saldoInicial; 
            }
            
        }
        public void Depositar(float valor)
        {
            if(valor >= 0)
            {
                Saldo = valor;
                return;
            }
            
            Console.WriteLine($"Valor para depósito inválido");
        }

        public float GetSaldo()
        {
            return Saldo;
        }

        public void Saque(float valor)
        {
            if(valor >= 0 && valor <= Saldo)
            {
                Saldo -= valor;
                System.Console.WriteLine("saque efetuado com sucesso!");
                return;
            }

            System.Console.WriteLine($"valor para saque inválido");
        }
    }
}