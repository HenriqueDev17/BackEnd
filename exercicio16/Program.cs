String cargo;
double salario, salario2 = 0;

Console.WriteLine("-------------------------------");
Console.WriteLine(" *-* escolha um dos cargos *-* ");
Console.WriteLine(" *-* Producao *-* ");
Console.WriteLine(" *-* administrativo *-*");
Console.WriteLine(" *-* diretoria *-* ");

cargo = Console.ReadLine();

Console.WriteLine("digite seu salario");
salario = double.Parse(Console.ReadLine());
if (cargo == "producao")
{
    salario2 = salario * 1.075;
}
else if (cargo == "administrativo")
{
    salario2 = salario * 1.075;
}
else if (cargo == "diretoria")
{
    salario2 = salario * 1.12;
}
else
{
    salario2 = salario;
    Console.WriteLine("cargo invalido, sem direito a reajuste");
}

    Console.WriteLine($"Seu novo salario e : {salario2}");
