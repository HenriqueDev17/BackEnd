int opcao = -1;

do
{
    Console.Clear();
    Console.WriteLine($"===== CALCULADORA =====");
    Console.WriteLine($"por favor escolha uma opção abaixo:");
    Console.WriteLine($"1 - Soma");
    Console.WriteLine($"2 - Subtração");
    Console.WriteLine($"3 - Multiplicação");
    Console.WriteLine($"4 - Divisão");
    Console.WriteLine($"0 - Sair");

    opcao = int.Parse(Console.ReadLine());
    double n1 = 0, n2 = 0;
    if (opcao != 0)
    {
        Console.WriteLine($"Digite o primeiro numero");
        n1 = double.Parse(Console.ReadLine());

        Console.WriteLine($"Digite o segundo numero");
        n2 = double.Parse(Console.ReadLine());
    }

    double resultado = 0;

    switch (opcao)
    {
        case 1:
            resultado = Soma(n1, n2);
            Console.WriteLine($"Resultado da soma: {resultado}");
            break;

        case 2:
            resultado = Subtracao(n1, n2);
            Console.WriteLine($"Resultado da subtracao: {resultado}");
            break;

        case 3:
            resultado = multiplicacao(n1, n2);
            Console.WriteLine($"Resultado da multiplicacao: {resultado}");
            break;

        case 4:
            if (n2 == 0)
            {
                Console.WriteLine($"Divisao por zero");
            }
            else
            {
                resultado = divisao(n1, n2);
                Console.WriteLine($"resultado da Divisão: {resultado}");
            }

            break;
        case 0:
            Console.WriteLine($"Obrigado por usar nosso programa");
            break;

    }
    Console.WriteLine($"Pressione qualquer tecla + <Enter> Para continuar...");
    Console.ReadLine();
} while (opcao != 0);

double Soma(double x, double y)
{
    return x + y;
}

double Subtracao(double x, double y)
{
    return x - y;
}

double multiplicacao(double x, double y)
{
    return x * y;
}

double divisao(double x, double y)
{
    return x / y;
}
