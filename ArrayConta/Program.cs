// Método Main()

using ArrayConta;

// Declarar o vetor de objetos
Conta[] vetContas = new Conta[3];

// Manipular o vetor instanciando e cadastrando
for (int i = 0; i < vetContas.Length; i++)
{
    vetContas[i] = new Conta();

    Console.Write("Digite o número: ");
    vetContas[i].numero = Convert.ToInt32(Console.ReadLine());
    Console.Write("Digite o titular: ");
    vetContas[i].titular = Console.ReadLine();
    Console.Write("Digite o saldo: ");
    vetContas[i].saldo = Convert.ToDouble(Console.ReadLine());
}

foreach (Conta c in vetContas)
    c.Extrato();