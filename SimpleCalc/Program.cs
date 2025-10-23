/*
Pedir o nome do usuário
Pedir dois números e
Mostrar a soma dos números no final
*/

using System.Runtime.CompilerServices;

string nome;
int numero1;
int numero2;

//pedir os nome pro usuário
Console.WriteLine("Digite seu nome");
nome = Console.ReadLine(); //pede o nome do usuário


Console.WriteLine(nome);//exibe o nome do usuário

//pedir dois numeros
Console.WriteLine("Digite o primeiro número");
numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número");
numero2 = int.Parse(Console.ReadLine());

int soma = numero1 + numero2;

Console.WriteLine(nome);
Console.WriteLine(soma);