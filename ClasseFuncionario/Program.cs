// Função main()

using ClasseFuncionario;
// Instanciar objeto para conseguir cadastrar algo.
Funcionario f1 = new Funcionario();

System.Console.Write("Digite o códgo: ");
f1.codigo = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Digite o nome: ");
f1.nome = Console.ReadLine();
System.Console.Write("Digite o salário: ");
f1.salario = Convert.ToDouble(Console.ReadLine());
f1.MostraAtributos(); // Enviando uma mensagem.

System.Console.WriteLine();

Funcionario f2 = new Funcionario();

System.Console.Write("Digite o códgo: ");
f2.codigo = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Digite o nome: ");
f2.nome = Console.ReadLine();
System.Console.Write("Digite o salário: ");
f2.salario = Convert.ToDouble(Console.ReadLine());
f2.MostraAtributos(); // Enviando uma mensagem.

System.Console.WriteLine();
double somaSalarios = f1.salario + f2.salario;
System.Console.WriteLine($"Soma dos salários: R$ {somaSalarios}");

System.Console.WriteLine();
System.Console.Write("Digite uma porcentagem de aumento: ");
int porcentagemAumento = Convert.ToInt32(Console.ReadLine());
f2.AumentarSalario(porcentagemAumento);
f2.MostraAtributos();