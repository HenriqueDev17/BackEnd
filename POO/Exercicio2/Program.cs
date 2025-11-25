using Exercicio2;
Console.Clear();

Funcionario f1 = new Funcionario();
f1.Nome = "Mangile";
f1.SalarioBase = 5000;

Gerente g1 = new Gerente();
g1.Nome = "Matheus";
g1.SalarioBase = 10000;
g1.Bonus = 2500;

System.Console.WriteLine($"Funcionario: {f1.Nome}");
System.Console.WriteLine($"Gerente: {g1.Nome}");