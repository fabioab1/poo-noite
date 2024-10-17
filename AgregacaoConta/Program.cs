// Método Main()

using AgregacaoConta;

Cliente cli1 = new Cliente("Fábio", 123456789);

Conta c1 = new Conta(1, 100);
c1.Titular = cli1;
Console.WriteLine("Número: " + c1.Numero + "\tTitular - Nome: " + c1.Titular.Nome + 
"\tTitular - RG: " + c1.Titular.Rg + "\tSaldo: " + c1.Saldo);

Conta c2 = new Conta(2, 200);
c2.Titular = new Cliente(); // Construtor padrão
c2.Titular.Nome = "Teo";
c2.Titular.Rg = 123456780;
Console.WriteLine("Número: " + c2.Numero + "\tTitular - Nome: " + c2.Titular.Nome + 
"\tTitular - RG: " + c2.Titular.Rg + "\tSaldo: " + c2.Saldo);