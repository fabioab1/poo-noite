using Classe;

Conta c1; // Declaração de uma variável

c1 = new Conta(); // Instância do objeto é do new para frente
c1.numero = 1;
c1.titular = "Fatec";
c1.saldo = 100;
System.Console.WriteLine($"Número da conta: {c1.numero}\nTitular: {c1.titular}\nSaldo: {c1.saldo}");

System.Console.WriteLine();

Conta c2 = new Conta();
c2.numero = 2;
c2.titular = "Empresa Jr";
c2.saldo = 200;
System.Console.WriteLine($"Número da conta: {c2.numero}\nTitular: {c2.titular}\nSaldo: {c2.saldo}");

System.Console.WriteLine();

Conta c3 = new Conta();
System.Console.Write("Cadastre o número da conta: ");
c3.numero = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Insira o nome do titular da conta: ");
c3.titular = Console.ReadLine();
System.Console.WriteLine("Insira o saldo existente na conta: ");
c3.saldo = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine($"Número da conta: {c3.numero}\nTitular: {c3.titular}\nSaldo: {c3.saldo}");

Funcionario f1 = new Funcionario();
f1.codigo = 1;
f1.nome = "Fábio";
f1.salario = 2000;
f1.MostrarInfos();