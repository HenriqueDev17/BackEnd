﻿int q = 0, i = 1, n = 0;

Console.WriteLine("Quantos numeros voce quer digitar");
q = int.Parse(Console.ReadLine());

while (n <= q)
{
    Console.WriteLine("Digite um numero");
    i = int.Parse(Console.ReadLine());
    if (i % 2 == 0)
    {
        Console.WriteLine($"O numero digitado é par: {i}");
    }
    n++;
}