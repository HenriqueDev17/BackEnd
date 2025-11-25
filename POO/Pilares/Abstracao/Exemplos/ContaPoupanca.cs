using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public class ContaPoupanca : ContaBancaria
    {
        public double Saldo;
        public override void Depositar(double valor)
        {
            if( valor <= 0 )
            {
                Console.WriteLine($"O valor do deposito deve ser maior que R$0,00");
                return;
            }

            Saldo += valor;
        }

        public override void Sacar(double valor)
        {
            double valorSaque = valor + (valor / 100);
           

             if( valor <= 0 )
            {
                Console.WriteLine($"O valor do deposito deve ser maior que R$0,00");
                return;
            }
            
            Saldo += valor;
        }
    }
}