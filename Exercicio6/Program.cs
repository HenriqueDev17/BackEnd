float n1, n2, n3, media, frequencia, continuar;
string nome = "";


do {
Console.WriteLine("Qual o nome do aluno");
nome = Console.ReadLine();

Console.WriteLine("Digite a nota de Matemática:");
n1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a nota de Português:");
n2 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a nota de História:");
n3 = float.Parse(Console.ReadLine());


Console.WriteLine("Digite a frequência (sem %):");
frequencia = float.Parse(Console.ReadLine());

media = (n1 + n2 + n3) / 4;

if (frequencia < 75)
    Console.WriteLine($"O aluno(a) {nome} foi Reprovado(a)");
 else
if (media >= 7)
    Console.WriteLine("O(A) " + (nome) + " foi Aprovado");
 else if (media < 3)
    Console.WriteLine("O(A) " + (nome) + " foi Reprovado");
else
    Console.WriteLine("O(A )" + (nome) + " esta de Recuperação");

    Console.WriteLine("");
    Console.WriteLine("");

    Console.WriteLine("Deseja continuar no sistema?");
    Console.WriteLine("1-Sim");
    Console.WriteLine("2-Não");
    continuar = int.Parse(Console.ReadLine());

} while (continuar == 1);