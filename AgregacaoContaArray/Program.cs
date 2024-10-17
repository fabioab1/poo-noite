// Método Main()

using AgregacaoContaArray;

Cliente cli1 = new Cliente("Teo", 1234);
Cliente cli2 = new Cliente("Paulo", 4321);
Cliente cli3 = new Cliente("Silva", 5678);

Conta c1 = new Conta(1, 10000); // Conta empresarial
c1.Titular = new List<Cliente>();
c1.Titular.Add(cli1);
c1.Titular.Add(cli2);
c1.Titular.Add(cli3);

Console.WriteLine(".................Apresentação da Conta.................");
c1.MostrarAtributos();
foreach (Cliente c in c1.Titular)
{
    c.MostrarAtributos();
}