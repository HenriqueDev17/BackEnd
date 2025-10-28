string[] nomes = new string[3];
double[] saldo = new double[3];
int  opcao = 1, totalCliente = 0;


do
{
    Console.Clear();
    Console.WriteLine($"=== SISTEMA BÁNCARIO SIMPLES ===");
    Console.WriteLine();

    Console.WriteLine($"1) Cadastrar Cliente");
    Console.WriteLine($"2) Depositar");
    Console.WriteLine($"3) Sacar");
    Console.WriteLine($"4) Transferir");
    Console.WriteLine($"5) Listar Clientes");
    Console.WriteLine($"0) Sair");
    Console.WriteLine($"Digite uma opção: ");
    opcao = int.Parse(Console.ReadLine());

    //chamar a função correta
    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Encerrando ...");
            Console.WriteLine($"Pressione <Enter> para encerrar ...");
            Console.ReadLine(); //para o sistema e espera o usuário digitar Enter!!
            break;

        case 1:
            CadastrarCliente();
            break;

        case 2:
            Depositar();
            break;

        case 3:
            Sacar();
            break;

        case 4:
            Transferir();
            break;

        case 5:
            listarCliente();
           
            break;

        default:
            Console.WriteLine($"opção Inválida, pressione <Enter> para continuar ...");
            Console.ReadLine();
            break;
    }

        Console.WriteLine($"Clique em <Enter para continuar>");
        Console.ReadLine();

} while (opcao != 0);



void CadastrarCliente()
{
    if (totalCliente >= 3)
    {
        Console.WriteLine($"Limite de ocupação atingido");
        Console.WriteLine($"Pressione <Enter> para continuar ...");
        Console.ReadLine();
        return;
    }
    //pedir os dados para o usúario (nome, idade)
    Console.WriteLine($"Digite o nome do cliente");
    string n = Console.ReadLine();
    Console.WriteLine($"Digite o saldo de {n}: ");
    int i = int.Parse(Console.ReadLine());
    // guardar/cadastrar os arrays
    nomes[totalCliente] = n;
    saldo[totalCliente] = i;
    totalCliente++;

    Console.WriteLine($"Cliente cadastrado com sucesso");
    Console.WriteLine($"Há {totalCliente} cliente(s) cadastrado(s) no sistema!");

}

void listarCliente()
{
    Console.WriteLine();
    Console.WriteLine($"== LISTA DE CLIENTE ");

    for (int i = 0; i < totalCliente;  i++)
    {
        Console.WriteLine($"Nome: {nomes[i]} | saldo: R$ {saldo[i]}:F2");

    }

}

void Depositar()
{
    int idCliente = BuscarCliente();
    if (idCliente == -1)
    {
        return;
    }
    Console.Write($"Valor para depósito: ");
    double valorDeposito = double.Parse(Console.ReadLine());
    saldo[idCliente] += valorDeposito;
    Console.WriteLine($"Depósito de R$ {valorDeposito} realizado! ");

}


int BuscarCliente()
{
    listarCliente();
    Console.WriteLine($"Digite o número do cliente");
    int idCliente = int.Parse(Console.ReadLine());

    if (idCliente < 0 || idCliente >= totalCliente)
    {
        Console.WriteLine($"Cliente não encontrado");
        return -1; //cliente não encontrado
    }

    return idCliente; //aqui vai ser devolvido o id do cliente (indice do array onde ele está cadastrado)
}


void Sacar()
{
    int idCliente = BuscarCliente();
    if (idCliente == -1)
    {
        return;
    }

    Console.Write($"Valor do saque: ");
    double valorSolicitado = double.Parse(Console.ReadLine());

    if (saldo[idCliente] >= valorSolicitado)
    {
        saldo[idCliente] -= valorSolicitado;
        Console.WriteLine($"Saque realizado com sucesso!");
    }
    else
    {
        Console.WriteLine($"Saldo Insuficiente");
    }

}


void Transferir()
{
    Console.WriteLine($"== Transferência ==");
    Console.WriteLine($"Conta de origem: ");
    int idClienteOrigem = BuscarCliente();
    if (idClienteOrigem == -1)
    {
        return;
    }
    Console.Write($"Conta destino: ");
    int idClienteDestino = BuscarCliente();
    if (idClienteDestino == -1)
    {
        return;
    }

    Console.Write($"Valor para transferir: ");

    double valor = double.Parse(Console.ReadLine());

    if (saldo[idClienteOrigem] >= valor)
    {
        saldo[idClienteOrigem] -= valor;
        saldo[idClienteDestino] += valor;
        Console.WriteLine($"Transferencia comcluida");
    }
    else
    {
        Console.WriteLine($"saldo insuficiente!");
    }
}