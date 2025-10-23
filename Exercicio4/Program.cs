int senha;

do
{
   Console.Write("Digite a senha:");
   senha = int.Parse(Console.ReadLine());

   if (senha == 1234)
      Console.WriteLine("ACESSO PERMITIDO");
   else
      Console.WriteLine("ACESSO NEGADO");
} while (senha != 0);