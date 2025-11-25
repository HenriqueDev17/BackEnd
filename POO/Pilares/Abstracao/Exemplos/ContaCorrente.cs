using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public class ContaCorrente : ContaBancaria
    {
       
        public double Saldo;
        private double Taxa = 0.05;
      
        public override void Depositar(double valor)
        {
            if( valor <= 0 )
            {
        Console.WriteLine($"O valor do saque deve ser maior que R$0,00");
        return;
            }

            Saldo += valor;


        }
        public override void Sacar(double valor)
        {
            double totalComTaxa = valor + (valor * Taxa);

            if( valor <= 0 || totalComTaxa >= Saldo )
            {
                Console.WriteLine($"O valor do deposito deve ser maior que R$0,00");
                return;

             
            }
               Saldo -= totalComTaxa;
        }
    }
}