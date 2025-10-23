int opcao;

    Console.Clear();
    Console.WriteLine("");
    Console.WriteLine("----------------------------");
    Console.WriteLine("     Bem Vindo, usuario     ");
    Console.WriteLine("----------------------------");
Console.WriteLine("");
    
do
{
    Console.WriteLine("Escolha uma opção no menu abaico");
    Console.WriteLine("1- Opção 1");
    Console.WriteLine("2- Opção 2");
    Console.WriteLine("3- Opção 3");
    Console.WriteLine("0- Sair");

    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            saudacao();
            Console.WriteLine("Voce escolheu a opcao 1");
            break;
        case 2:
            saudacao();
            Console.WriteLine("Voce escolheu a opcao 2");
            break;
        case 3:
            saudacao();
            Console.WriteLine("Voce escolheu a opcao 3");
            break;
        case 0:
            saudacao();
            Console.WriteLine("Saindo do programa...");
            break;
        default:
            saudacao();
            Console.WriteLine("Opção inválida");
            break;
    }

    void saudacao()
    {
        Console.WriteLine("Olá, meu amigo :)");
    }
}
while (opcao != 0);