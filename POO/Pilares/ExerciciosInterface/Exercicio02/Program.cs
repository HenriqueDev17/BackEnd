using Exercicio02;

List<IImprimivel> documentos = new List<IImprimivel>();

int opcao;
do
{

Console.WriteLine($"Menu de Opções");
Console.WriteLine($@"
1) Cadastrar Fatura
2) Cadastrar Relatório
3) Cadastrar Contrato
4) Listar Faturas
5) Listar Relatórios
6) Listar Contratos
Escolha a opção:");
opcao = int.Parse(Console.ReadLine());


switch (opcao)
    {
        case 1:
        Console.WriteLine($"Cadastrar Fatura");
        CadastrarFatura();
        break;

        case 2:
        Console.WriteLine($"Cadastrar Relatório");
        CadastrarRelatorio();
        break;

        case 3:
        Console.WriteLine($"Cadastrar Contrato");
        CadastrarContrato();
        break;

        case 4:
        Console.WriteLine($"Listar Faturas");
        break;

        case 5:
        Console.WriteLine($"Listar Relatórios");
        break;

        case 6:
        Console.WriteLine($"Listar Contratos");
        break;

        case 0:
        Console.WriteLine($"Sair");
        break;
        default:
        Console.WriteLine($"Opção Inválida");
        break;
        

    }

Console.WriteLine($"Digite <Enter> para continuar...");
Console.ReadLine();
} while (opcao != 0);

void CadastrarFatura()
{
    
    Console.Write($"Digite o nome do devedor: ");
    string dev = Console.ReadLine();
    
    Console.Write($"Digite o nome do credor: ");
    string cred = Console.ReadLine();
    
    Console.Write($"Digite o valor da fatura: ");
    float valor = float.Parse (Console.ReadLine());
    
    Console.WriteLine($"Quantos dias a fatura está em atraso?");
    int DiasAtraso = int.Parse(Console.ReadLine());

    Fatura f = new Fatura("Eduardo", "Bradesco Cartões", 1000.98f, 10);
    documentos.Add(f);

}

void CadastrarContrato()
{
    
    Console.WriteLine($"Digite o nome do contratante: ");
    string contratante = Console.ReadLine();
    
    Console.WriteLine($"Digite o nome da empresa contratada: ");
    string contratada = Console.ReadLine();
    
    Console.WriteLine($"digite as clausulas do contrato: ");
    string txtClausulas = Console.ReadLine();

    Contrato c = new Contrato(contratante, contratada, txtClausulas);
    documentos.Add(c);
}

void CadastrarRelatorio()
{
  
    Console.WriteLine("Digite o nome do responsavel pelo relatório: ");
    string resp = Console.ReadLine();
   
    Console.WriteLine("Digite o texto do relotorio: ");
    string txt = Console.ReadLine();

    Relatorio r = new Relatorio(resp, txt);
    documentos.Add(r);
    
    Console.WriteLine($"Relatorio cadastrado com sucesso");
}

void ListarFaturas()
{
    Console.WriteLine($"Listando as faturas");
    foreach (var item in documentos)
    {
        if (item is Fatura)
        {
            item.Imprimir();
        }
    }
}

void ListarContrato()
{
    Console.WriteLine($"Listando os contratos");
    foreach (var item in documentos)
    {
        if (item is Contrato)
        {
            item.Imprimir();
        }
    }
}

void ListarRelatorio()
{
    Console.WriteLine($"Listando os relatorios");
    foreach (var item in documentos)
    {
        if (item is Relatorio)
        {
            item.Imprimir();
        }
    }
}
















// Fatura fatEdu = new Fatura("Eduardo", "Izabel Dark Lab", 50, 1);

// fatEdu.Imprimir();