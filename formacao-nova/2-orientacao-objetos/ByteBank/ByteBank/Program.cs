using ByteBank;
using ByteBank.Titular;


Console.WriteLine("Boas Vindas ao seu banco, ByteBank!");

/*
ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "Diana Carolina";
conta1.conta = "12345-x";
conta1.numeroAgencia = 12;
conta1.nomeAgencia = "Agencia Centro";
conta1.saldo = 100;

ContaCorrente conta2 = new ContaCorrente();
conta2.titular = "Francisco de Paula";
conta2.conta = "54321-x";
conta2.numeroAgencia = 30;
conta2.nomeAgencia = "Agencia Sul";
conta2.saldo = 100;

Console.WriteLine("Saldo do Francisco pré-saque: " + conta2.saldo);

bool saque = conta2.Sacar(50);
Console.WriteLine("Saque realizado? " + saque);
Console.WriteLine("Saldo do Francisco pós-saque: " + conta2.saldo);
Console.WriteLine("\n");

conta2.Depositar(60);
Console.WriteLine("Saldo do Francisco pós-deposito: " + conta2.saldo);
Console.WriteLine("\n");

Console.WriteLine("Saldo do Diana pré-transferência: " + conta1.saldo);
Console.WriteLine("Saldo do Francisco pré-transferência: " + conta2.saldo);
Console.WriteLine("\n");

bool tranferencia = conta1.Transferir(25, conta2);
Console.WriteLine("Saque realizado? " + saque);
Console.WriteLine("Saldo do Diana pós-transferência: " + conta1.saldo);
Console.WriteLine("Saldo do Francisco pós-transferência: " + conta2.saldo);
*/

Cliente cliente = new Cliente();
cliente.nome = "Anna";
cliente.cpf = "13415679915";
cliente.profisao = "Arquiteta";

ContaCorrente conta3 = new ContaCorrente();
conta3.titular = cliente;
conta3.conta = "321654-X";
conta3.numeroAgencia = 35;
conta3.nomeAgencia = "Agencia Central";

Console.WriteLine(cliente.nome);
Console.WriteLine(conta3.titular.nome);

Console.ReadKey();