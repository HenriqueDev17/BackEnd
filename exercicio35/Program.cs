﻿int n = 0, contador = 0, n1 = 0, n2 = 0;

Console.WriteLine("digite um número de repetição");
n = int.Parse(Console.ReadLine());

while (contador < n);
{
    Console.WriteLine("Digite o primeiro numero");
    n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo numero");
    n2 = int.Parse(Console.ReadLine());

    if (n1 > n2)
    {
        Console.WriteLine($"O Numero {n1} e maior que o numero {n2}");
    }
    else if (n1 < n2)
    {
        Console.WriteLine($"O Numero {n2} e maior que o numero {n1}");
    }
    else
    {
        Console.WriteLine($"Os dois numeros sao iguais: {n1} = {n2}");
    }
    contador++;
}