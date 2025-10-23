Console.Clear();//limpa tela
Console.WriteLine($"Digite seu nome:");//pede o nome do usuário
string nomeUsuario = Console.ReadLine();//guarda o nome na variável
Cumprimento(nomeUsuario);//chama a função e passa o nome

int opcao = -1;

do
{//todo o programa aqui dentro
//desenha um menu de opções
Console.WriteLine("Escolha uma opção no menu abaixo:");
Console.WriteLine(" 1 - Coxinha");
Console.WriteLine(" 2 - Pastel");
Console.WriteLine(" 3 - Caldo de Cana");
Console.WriteLine(" 4 - Bolo de Chocolate");
Console.WriteLine(" 0 - Sair");
//captura a opção do usuário
opcao = int.Parse(Console.ReadLine());

//escolhe a opção indicada pelo usuário
switch (opcao)
{
    case 1:
    escolha1();
        break;
    case 2:
    escolha2();
        break;
    case 3:
    escolha3();
        break;

    case 4:
    escolha4();
        break;
    case 0:
    escolha5();
        break;
    default:
    Console.WriteLine($"Não temos esta opção {opcao}!!");
        break;
}

} while (opcao != 0);

Console.Clear();
Console.WriteLine($"FIM DO PROGRAMA");



// tipoDeDado Nome (parâmetros){corpo}

void Cumprimento(string n)
{
    Console.WriteLine($"Olá, {n}");
}

void escolha1()
{
    Console.WriteLine($"Voce escolheu a opcao {opcao} - Coxinha");
}

void escolha2()
{
    Console.WriteLine($"Voce escolheu a opcao {opcao} - Pastel");
}

void escolha3()
{
    Console.WriteLine($"Voce escolheu a opcao {opcao} - Caldo de cana");
}

void escolha4()
{
    Console.WriteLine($"Voce escolheu a opcao {opcao} - Bolo de chocolate");
}

void escolha5()
{
    Console.WriteLine($"Voce escolheu a opcao {opcao} - Sair");
}