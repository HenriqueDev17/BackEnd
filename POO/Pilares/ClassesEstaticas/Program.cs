// See https://aka.ms/new-console-template for more information
using ClassesEstaticas;

Console.WriteLine("Bem vindo ao programa");
Console.WriteLine();

Console.WriteLine($"Digite um número: ");
float a = float.Parse(Console.ReadLine());
Console.WriteLine("Digite outro número: ");
float b = float.Parse(Console.ReadLine());

Console.WriteLine($@"O maior valor é {Math.Max(a, b)}
 e o valor menor é: {Math.Min(a, b)}");

// //uso da classe estática de forma auxiliar
// float r = CalculosMatematicos.Somar(a, b);
// Console.WriteLine($"Soma: {r}");

// float d = CalculosMatematicos.Dividir(a, b);
// Console.WriteLine($"Divisão: {d}");

// float s = CalculosMatematicos.Subtrair(a, b);
// Console.WriteLine($"Subtração: {s}");

// float m = CalculosMatematicos.Multiplicar(a, b);
// Console.WriteLine($"Multiplicação: {m}");

