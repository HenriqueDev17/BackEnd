﻿/*Faça um programa que o usuário informe o salário recebido e o total gasto.
 Deverá ser exibido na tela “Gastos dentro do orçamento” 
 caso o valor gasto não ultrapasse o valor do salário e “Orçamento estourado” 
 se o valor gasto ultrapassar o valor do salário.*/

double salario = 0, gasto = 0;
int continuar;

do
{
    Console.WriteLine("Informe o seu salário");
    salario = double.Parse(Console.ReadLine());

    Console.WriteLine("Informe o total gasto");
    gasto = double.Parse(Console.ReadLine());

    if (salario > gasto)
        Console.WriteLine("Gastos dentro do orçamento");
    else
        Console.WriteLine("Orçamento estourado");

    Console.WriteLine("");
    Console.WriteLine("");

    Console.WriteLine("Deseja continuar no sistema?");
    Console.WriteLine("1-Sim");
    Console.WriteLine("2-Não");
    continuar = int.Parse(Console.ReadLine());

} while (continuar == 1);