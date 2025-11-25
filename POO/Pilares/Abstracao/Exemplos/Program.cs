using Exemplos;

ContaCorrente cc = new ContaCorrente();
ContaPoupanca cp = new ContaPoupanca();

cc.Depositar(10);
cp.Depositar(10);

Console.WriteLine($"Saldo Conta Corrente Antes Do Saque: R${cc.Saldo}");
Console.WriteLine($"Saldo Conta Poupança Antes Do Saque: R${cp.Saldo}");
cc.Sacar(10);
cp.Sacar(5);

Console.WriteLine();

Console.WriteLine($"Saldo Conta Corrente Após o Saque: {cc.Saldo}");
Console.WriteLine($"Saldo Poupança Após o Saque: R${cp.Saldo}");