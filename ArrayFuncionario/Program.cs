// Main

using ArrayFuncionario;

// Criar um vetor de 3 elementos
// Cadastrar/digitar
Funcionario[] vetFuncionarios = new Funcionario[3];

double totalSalarios = 0;

for (int i = 0; i < vetFuncionarios.Length; i++)
{
    vetFuncionarios[i] = new Funcionario();

    Console.Write("Digite o código: ");
    vetFuncionarios[i].codigo = Convert.ToInt32(Console.ReadLine());
    Console.Write("Digite o nome: ");
    vetFuncionarios[i].nome = Console.ReadLine();
    Console.Write("Digite o salário: ");
    vetFuncionarios[i].salario = Convert.ToDouble(Console.ReadLine());
    totalSalarios += vetFuncionarios[i].salario;
}

// Calcule o total de salários de todos os funcionários
Console.WriteLine($"Soma total dos salários: {totalSalarios:c}");

// Pesquise se há algum funcionário com 100 de salário,
// informe se encontrou ou não

bool encontrado = false;

foreach (Funcionario f in vetFuncionarios)
{
    if (f.salario == 100)
    {
        Console.WriteLine("Funcionário com 100 de salário encontrado." + f.nome);
        encontrado = true;
        break;
    }
}

if (!encontrado)
    Console.WriteLine("Nenhum funcionário com 100 de salário encontrado.");