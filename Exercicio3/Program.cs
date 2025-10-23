double L1, L2, L3;
int continuar;

do {
    Console.WriteLine("Informe a medida do primeiro lado:");
    L1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Informe a medida do segundo lado:");
    L2 = double.Parse(Console.ReadLine());

    Console.WriteLine("Informe a medida do Terceiro lado:");
    L3 = double.Parse(Console.ReadLine());

    if (L1 == L2 && L3 == L1)
        Console.WriteLine("O Triângulo é Equilatero");
    else if ((L1 == L2 && L1 != L3) || (L1 == L3 && L1 != L2) || (L2 == L3 && L2 != L1))
        Console.WriteLine("O Triângulo é Isóceles");
    else
        Console.WriteLine("O Triângulo é Escaleno");

    Console.WriteLine("Deseja continuar no sistema?");
    Console.WriteLine("1-Sim");
    Console.WriteLine("2-Não");
    continuar = int.Parse(Console.ReadLine());

} while (continuar == 1);