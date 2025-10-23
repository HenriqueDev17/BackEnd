double nota1, nota2, nota3, nota4, media;

Console.WriteLine("Digite a primeira nota:");
nota1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a segunda nota:");
nota2 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a terceira nota:");
nota3 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a quarta nota:");
nota4 = double.Parse(Console.ReadLine());

media = (nota1 + nota2 + nota3 + nota4) / 4;
Console.Write($"Média: {media}, ");

if (media >= 7)
{
    Console.WriteLine("Aprovado");
}

else if (media >= 5)
{
    Console.WriteLine("Recuperacao");
}

else
{
    Console.WriteLine("Reprovado");
}


