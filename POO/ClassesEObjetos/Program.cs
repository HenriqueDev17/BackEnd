using ClassesEObjetos;

// Pessoa joao = new Pessoa();

// joao.Nome = "João Silva";

// Console.WriteLine($"{joao.Nome} tem {joao.Idade} anos");

// int novaIdade = joao.Envelhecer(17);

// Console.WriteLine($"{joao.Nome} tem {novaIdade} anos");

// novaIdade = joao.Envelhecer(-50);
// Console.WriteLine($"{joao.Nome} tem {joao.Idade} anos");
Console.WriteLine($"-- Agência Bnacária --");
Console.WriteLine($"Digite o nome do titular da conta: ");
string nomeT = Console.ReadLine();

ContaBancaria conta = new ContaBancaria(nomeT);

Console.WriteLine();
Console.WriteLine($"Bem vindo, {conta.Titular}");
Console.WriteLine($"Saldo inicil: R$ {conta.Saldo:F2}");
Console.WriteLine();

int opcao = 0;
do
{
    Console.WriteLine($"\n Menu");
    Console.WriteLine($"1 - Depositar");
    Console.WriteLine($"2 - Sacar");
    Console.WriteLine($"0 - Sair");
    opcao = int.Parse(Console.ReadLine());

    Console.WriteLine();

    switch (opcao)
    {
        case 1:
            Console.WriteLine($"Digite o valor do déposito");
    }
}
