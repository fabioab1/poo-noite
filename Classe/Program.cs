using Classe;

// Conta c1; // Declaração de uma variável

// c1 = new Conta(); // Instância do objeto é do new para frente
// c1.numero = 1;
// c1.titular = "Fatec";
// c1.saldo = 100;
// System.Console.WriteLine($"Número da conta: {c1.numero}\nTitular: {c1.titular}\nSaldo: {c1.saldo}");

// System.Console.WriteLine();

// Conta c2 = new Conta();
// c2.numero = 2;
// c2.titular = "Empresa Jr";
// c2.saldo = 200;
// System.Console.WriteLine($"Número da conta: {c2.numero}\nTitular: {c2.titular}\nSaldo: {c2.saldo}");

// System.Console.WriteLine();

// Conta c3 = new Conta();
// System.Console.Write("Cadastre o número da conta: ");
// c3.numero = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Insira o nome do titular da conta: ");
// c3.titular = Console.ReadLine();
// System.Console.WriteLine("Insira o saldo existente na conta: ");
// c3.saldo = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine($"Número da conta: {c3.numero}\nTitular: {c3.titular}\nSaldo: {c3.saldo}");

// Funcionario f1 = new Funcionario();
// f1.codigo = 1;
// f1.nome = "Fábio";
// f1.salario = 2000;
// f1.MostrarInfos();

int opt;
int tamanho = 5;
string logomarca = "";


System.Console.WriteLine("Bem vindo ao Sistemarket v2.0");
System.Console.WriteLine("Pressione qualquer tecla para continuar...");
Console.ReadKey();

do
{
    Console.Clear();

    System.Console.WriteLine("Menu de configurações:");
    System.Console.WriteLine("1. Definir a quantidade máxima de produtos do sistema.");
    System.Console.WriteLine("2. Definir a logomarca do menu do sistema.");
    System.Console.WriteLine("3. Concluir e ir para o sistema.");
    System.Console.Write("Digite a opção desejada: ");
    opt = Convert.ToInt32(Console.ReadLine());

    if (opt == 1)
    {
        System.Console.Write("Informe o número máximo de produtos a serem cadastrados: ");
        tamanho = Convert.ToInt32(Console.ReadLine());
    }
    else if (opt == 2)
    {
        System.Console.Write("Digite a logomarca da sua empresa: ");
        logomarca = Console.ReadLine();
    }

} while (opt > 0 && opt < 3);

Produto[] produtos = new Produto[tamanho];

do
{
    Console.Clear();

    Console.WriteLine(logomarca);
    Console.WriteLine("Registro de produtos");
    Console.WriteLine();
    Console.WriteLine("Menu:");
    System.Console.WriteLine("1. Cadastrar produtos");
    System.Console.WriteLine("2. Visualizar produtos");
    System.Console.WriteLine("3. Exibir somatório de preços");
    System.Console.WriteLine("4. Finalizar");
    System.Console.Write("Digite a opção desejada: ");
    opt = Convert.ToInt32(Console.ReadLine());

    if (opt == 1)
    {
        for (int i = 0; i < produtos.Length; i++)
        {
            if (produtos[i] == null)
            {
                Produto produto = new Produto();

                System.Console.Write("Digite o nome do produto: ");
                produto.nome = Console.ReadLine();
                System.Console.Write("Digite o preço do produto: ");
                produto.preco = Convert.ToDouble(Console.ReadLine());

                int cod = 0;

                foreach (Produto p in produtos)
                {
                    if (p != null)
                    {
                        if (p.codigo == cod)
                            cod++;
                    }
                }

                produto.codigo = cod;
                produtos[i] = produto;
                System.Console.WriteLine("Produto cadastrado!");
                produto.VisualizarDados();

                System.Console.WriteLine();
            }
        }

        System.Console.WriteLine();

        System.Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
    }
    else if (opt == 2)
    {
        foreach (Produto p in produtos)
        {
            if (p != null)
                System.Console.WriteLine($"Código: {p.codigo}\tNome: {p.nome}\tPreço: R$ {p.PrecoFormatado()}");
        }

        System.Console.WriteLine();

        System.Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
    }
    else if (opt == 3)
    {
        double somatorioPreco = 0;

        foreach (Produto p in produtos)
        {
            if (p != null)
                somatorioPreco += p.preco;
        }

        System.Console.WriteLine($"Somatório do preço de todos os produtos: R$ {somatorioPreco.ToString("0.00")}");

        System.Console.WriteLine();

        System.Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
    }

} while(opt > 0 && opt < 4);