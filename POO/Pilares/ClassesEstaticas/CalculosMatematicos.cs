using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesEstaticas
{
    public static class CalculosMatematicos
    {
        //Public significa A visibilidade, Void é o tipo de retorno, Somar é o nome(parametro)
        public static float Somar(float a, float b)
        {
            return a + b;
        }

        public static float Dividir(float a, float b)
        {
            if(b ==0)
         {
            Console.WriteLine($"Divisão Inválida");
            return 0;
         }
            return a / b;
        }

         public static float Subtrair(float a, float b)
        {
            return a - b;
        }

           public static float Multiplicar(float a, float b)
        {
            return a * b;
        }


    }
}