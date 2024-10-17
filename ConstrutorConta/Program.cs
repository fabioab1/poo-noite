// Main
using ConstrutorConta;

Conta c1 = new Conta();
c1.Extrato();

Conta c2 = new Conta(20);
c2.Extrato();

Conta c3 = new Conta(30, "Fábio");
c3.Extrato();

Conta c4 = new Conta(40, "Tobias", 15.00);
c4.Extrato();
System.Console.WriteLine($"Quantida de instâncias: {Conta.Contador}");