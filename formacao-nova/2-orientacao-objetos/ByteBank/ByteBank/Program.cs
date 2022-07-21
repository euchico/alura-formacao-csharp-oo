using ByteBank;

Console.WriteLine("Boas Vindas ao seu banco, ByteBank!");

ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "Diana Carolina";
conta1.conta = "12345-x";
conta1.numeroAgencia = 12;
conta1.nomeAgencia = "Agencia Centro";
conta1.saldo = 100;

/*
ContaCorrente conta2 = new ContaCorrente();
conta2.titular = "Francisco de Paula";
conta2.conta = "54321-x";
conta2.numeroAgencia = 30;
conta2.nomeAgencia = "Agencia Sul";
conta2.saldo = 200;

Console.WriteLine("Titular: " + conta1.titular);
Console.WriteLine("Conta: " + conta1.conta);
Console.WriteLine("Número Agencia: " + conta1.numeroAgencia);
Console.WriteLine("Nome da Agencia: " + conta1.nomeAgencia);
Console.WriteLine("Saldo: " + conta1.saldo);
*/



Console.ReadKey();