using System.Net.WebSockets;

string[] nomes = new string[4];
int[] idades = new int[4];
int opcao = -1, totalAlunos = 0;


// nomes[0] = "Maria";
// idades[0] = 20;

// nomes[1] = "Matheus";
// idades[1] = 16;

// nomes[2] = "Eloysa";
// idades[2] = 17;

// nomes[3] = "Felipe";
// idades[3] = 17;



//Estrutura do menu

do
{

    Console.WriteLine($"1) Cadastrar Alunos");
    Console.WriteLine($"2) Listar Alunos");
    Console.WriteLine($"0) Sair");
    Console.WriteLine($"Digite uma opção: ");
    opcao = int.Parse(Console.ReadLine());

    //chamar a funcção correta
    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Encerrando ...");
            Console.WriteLine($"Pressione <Enter> para encerrar ...");
            Console.ReadLine(); //para o sistema e espera o usuário digitar Enter!!
            break;

        case 1:
            CadastrarAluno();
            break;

        case 2:
            ListarAlunos();
            break;

        default:
            Console.WriteLine($"opção Inválida, pressione <Enter> para continuar ...");
            Console.ReadLine();
            break;
    }

} while (opcao != 0);



void CadastrarAluno()
{
    //verificar se em espaço no array para cadastrar (total)
    if (totalAlunos >= 4)
    {
        Console.WriteLine($"Não Limite de ocupação atingido");
        Console.WriteLine($"Pressione <Enter> para continuar ...");
        Console.ReadLine();
        return;
    }
    //pedir os dados para o usúario (nome, idade)
    Console.WriteLine($"Digite o nome do aluno");
    string n = Console.ReadLine();
    Console.WriteLine($"Digite a idade de {n}");
    int i = int.Parse(Console.ReadLine());

    // guardar/cadastrar os arrays
    nomes[totalAlunos] = n;
    idades[totalAlunos] = 1;
    totalAlunos++;

    Console.WriteLine($"Aluno cadastrado com sucesso");
    Console.WriteLine($"Há {totalAlunos} aluno(s) cadastrado(s) no sistema!");
    Console.WriteLine($"Pressione <Enter> para continuar");
    Console.ReadLine(); //parar o sistemar e esperar o usuário dar um <Enter>
}



//função para exibir os alunos
void ListarAlunos()
{
    Console.WriteLine();
    Console.WriteLine($"Resultado: ");

for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"Nome: {nomes[i]} ");
    Console.WriteLine($"Idade: {idades[i]} ");
    Console.WriteLine();
}
    Console.WriteLine($"Pressione <Enter> para continuar ...");
    Console.ReadLine();
}







