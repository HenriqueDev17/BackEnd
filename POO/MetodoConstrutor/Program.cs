using System.Security.Cryptography.X509Certificates;
using MetodoConstrutor;
// Pessoa fontes = new Pessoa("João", 17);
// //fontes.Nome = "Lorenzo";
// //fontes.Idade = 20;

// System.Console.WriteLine($"O objeto pessoa que criei é o {fontes.Nome} com a idade {fontes.Idade}");

// //fontes.Nome = "Gustavo Oliveira";

// //fontes.Nome = "Henrique";
// fontes.ExibirDados();

//primeiro metodo construtor da class 
Pessoa3Sobrecargas PrimeiraPessoa = new Pessoa3Sobrecargas();
System.Console.WriteLine(@$"Primeira pessoa cadastrada:
                            Nome: {PrimeiraPessoa.Nome}
                            Idade: {PrimeiraPessoa.Idade}
                           
");
//segundo metodo construtor da class 
Pessoa3Sobrecargas SegundaPessoa = new Pessoa3Sobrecargas("Matheus Felix");
System.Console.WriteLine(@$"Segunda pessoa cadastrada:
                            Nome: {SegundaPessoa.Nome}
                            Idade: {SegundaPessoa.Idade}
                           
");



//terceiro metodo construtor da class 
Pessoa3Sobrecargas TerceiraPessoa = new Pessoa3Sobrecargas("Felipe Silva", 16);
Console.WriteLine(@$"Digite sua nome: ");
TerceiraPessoa.Nome = Console.ReadLine();
Console.WriteLine("Digite sua idade: ");
TerceiraPessoa.Idade = int.Parse(Console.ReadLine());

   System.Console.WriteLine(@$"Terceira pessoa cadastrada:
                            Nome: {TerceiraPessoa.Nome}
                            Idade: {TerceiraPessoa.Idade}

");



