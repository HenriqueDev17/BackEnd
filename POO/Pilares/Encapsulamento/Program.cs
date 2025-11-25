using Encapsulamento;

// float dinheiro = 200;

// ContaBancaria contaEdu = new ContaBancaria();
// ContaBancaria contaHenrique = new ContaBancaria(dinheiro);

// contaEdu.Depositar(dinheiro);

// Console.WriteLine($"Saldo do edu: R$:{contaEdu.GetSaldo()}");

// Console.WriteLine($"Saldo do henrique: R$:{contaHenrique.GetSaldo()}");

// contaEdu.Saque(100);
// Console.WriteLine($"Saldo apos o saque do edu: RS${contaEdu.GetSaldo()}");

Carro fusca = new Carro();

fusca.DefinirMarca("volkswagen");
fusca.DefinirModelo("Fusca 89");

fusca.Acelera(100);
fusca.Acelera(50);

fusca.Frear(10);

Console.WriteLine($"Marca: {fusca.ObterMarca()}");
Console.WriteLine($"Modelo: {fusca.ObterModelo()}");
Console.WriteLine($"Velocidade atual: {fusca.ObterVelocidade()}");