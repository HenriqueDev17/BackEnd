using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosMetodoConstrutor
{
    public class ContaBancaria
    {
        public string Titular;
        public double Saldo;
        public ContaBancaria(string titular, double saldoInicial = 0)
        {
            Titular = titular;
            Saldo = saldoInicial;
        }
        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine($"Déposito no valor de R$ {valor:F2} realizado");
            }
            else
            {
                Console.WriteLine($"O valor depositado deve ser maior que 0.");
            }
        }
        public void Sacar(double valor)
        {
            if (valor > 0 && valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque no valor de R$ {Saldo:F2} realizado");
            }
            else{}
        }
    }
}
