﻿/* Desenvolva um programa que recebe do usuário, o placar de um jogo de futebol
(os gols de cada time) e informa se o resultado foi um empate, 
se a vitória foi do primeiro time ou do segundo time.*/

int time1, time2, continuar;

do
{
    Console.WriteLine("Gols do primeiro time: ");
    time1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Gols do segundo time: ");
    time2 = int.Parse(Console.ReadLine());

    if (time1 > time2)
        Console.WriteLine("O primeiro time venceu");
    else if (time1 < time2)
        Console.WriteLine("O segundo time venceu");
    else
        Console.WriteLine("Empataram");

    Console.WriteLine("Deseja continuar no sistema?");
    Console.WriteLine("1-Sim");
    Console.WriteLine("2-Não");
    continuar = int.Parse(Console.ReadLine());

} while (continuar == 1);