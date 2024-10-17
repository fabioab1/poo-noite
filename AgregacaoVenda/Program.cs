using AgregacaoVenda;
using System.Threading;

internal class Program
{
    private static void Main(string[] args)
    {
        int i = 0;
        while (i <= 100)
        {
            Console.Clear();
            Console.WriteLine("Varejo Vendas v1.0");
            Console.Write("Carregando: ");
            Console.Write(i+"%");
            i+=10;
            Thread.Sleep(500);
        }

        Console.Clear();
        Console.WriteLine("Seja bem-vindo!");
        Thread.Sleep(500);
        
        int opc;
        List<Vendedor> vends = new List<Vendedor>();
        List<Comprador> comps = new List<Comprador>();
        List<Venda> vendas = new List<Venda>();

        do
        {
            Console.Clear();
            Console.WriteLine("1 - Cadastrar vendedor");
            Console.WriteLine("2 - Cadastrar comprador");
            Console.WriteLine("3 - Visualizar atributos");
            Console.WriteLine("4 - Nova venda");
            Console.WriteLine("5 - Exibir cadastrados");
            Console.WriteLine("6 - Sair");

            Console.Write("Digite a opção desejada: ");
            opc = Convert.ToInt32(Console.ReadLine());

            if (opc == 1)
            {
                Console.Write("Digite o nome do vendedor: ");
                string nome = Console.ReadLine();
                bool nomeExistente = false;

                foreach (Vendedor v in vends)
                {
                    if (v.Nome == nome)
                    {
                        nomeExistente = true;
                        Console.WriteLine($"O vendedor \"{nome}\" já existe.");
                        break;
                    }
                }

                if (!nomeExistente)
                {
                    Vendedor v = new Vendedor(nome);
                    vends.Add(v);
                    Console.WriteLine($"Vendedor \"{nome}\" adicionado com sucesso.");
                    v.MostrarAtributos();
                }
            }
            else if (opc == 2)
            {
                Console.Write("Digite o nome do comprador: ");
                string nome = Console.ReadLine();
                bool nomeExistente = false;

                foreach (Comprador c in comps)
                {
                    if (c.Nome == nome)
                    {
                        nomeExistente = true;
                        Console.WriteLine($"O comprador \"{nome}\" já existe.");
                        break;
                    }
                }

                if (!nomeExistente)
                {
                    Console.Write("Digite a verba do comprador: ");
                    double verba = Convert.ToInt32(Console.ReadLine());
                    Comprador c = new Comprador(verba, nome);
                    comps.Add(c);
                    Console.WriteLine($"Comprador \"{nome}\" adicionado com sucesso.");
                    c.MostrarAtributos();
                }
            }
            else if (opc == 3)
            {
                Console.WriteLine("1 - Vendedor");
                Console.WriteLine("2 - Comprador");
                Console.Write("Digite a opção desejada: ");
                int opcT = Convert.ToInt32(Console.ReadLine()); // Opção temporária
                
                if (opcT == 1)
                {
                    Console.Write("Digite o nome do vendedor: ");
                    string nome = Console.ReadLine();
                    bool vendEncontrado = false;

                    foreach (Vendedor v in vends)
                    {
                        if (v.Nome == nome)
                        {
                            v.MostrarAtributos();
                            vendEncontrado = true;
                        }
                    }

                    if (!vendEncontrado)
                        Console.WriteLine($"Vendedor \"{nome}\" não encontrado.");
                }
                else if (opcT == 2)
                {
                    Console.Write("Digite o nome do comprador: ");
                    string nome = Console.ReadLine();
                    bool compEncontrado = false;

                    foreach (Comprador c in comps)
                    {
                        if (c.Nome == nome)
                        {
                            c.MostrarAtributos();
                            compEncontrado = true;
                        }
                    }

                    if (!compEncontrado)
                        Console.WriteLine($"Comprador \"{nome}\" não encontrado.");
                }
                else
                    Console.WriteLine("Opção inválida.");
            }
            else if (opc == 4)
            {
                Vendedor vendVenda = null;
                Comprador compVenda = null;
                List<Produto> prodsVenda = new List<Produto>();

                // ----------- Informar vendedor ----------------
                Console.WriteLine("Vendedores disponíveis:");
                foreach (Vendedor v in vends)
                    v.MostrarAtributos();
                Console.Write("Digite o nome do vendedor para a venda: ");
                string nomeV = Console.ReadLine();
                bool vendEncontrado = false;

                foreach (Vendedor v in vends)
                {
                    if (v.Nome == nomeV)
                    {
                        vendVenda = v;
                        vendEncontrado = true;
                    }
                }
                if (!vendEncontrado)
                    Console.WriteLine($"Vendedor \"{nomeV}\" não encontrado.");
                else
                {
                    // ------------ Informar comprador ----------------
                    Console.WriteLine("Clientes disponíveis:");
                    foreach (Comprador c in comps)
                        c.MostrarAtributos();
                    Console.Write("Digite o nome do comprador para a venda: ");
                    string nomeC = Console.ReadLine();
                    bool compEncontrado = false;

                    foreach (Comprador c in comps)
                    {
                        if (c.Nome == nomeC)
                        {
                            compVenda = c;
                            compEncontrado = true;
                        }
                    }

                    if (!compEncontrado)
                        Console.WriteLine($"Comprador \"{nomeC}\" não encontrado.");
                    else
                    {
                        // ------------ Informar os produtos para compra -----------
                        double precoTotal = 0;
                        char opcT;
                        do
                        {
                            Console.Write("Digite o nome do produto: ");
                            string nomeP = Console.ReadLine();
                            Console.Write("Digite o preço do produto: ");
                            double preco = Convert.ToInt32(Console.ReadLine());
                            Produto p = new Produto(nomeP, preco);
                            prodsVenda.Add(p);
                            p.MostrarAtributos();
                            precoTotal += p.Preco;
                            Console.Write("Deseja cadastrar outro produto? (s/n):");
                            opcT = Console.ReadKey().KeyChar;
                            Console.WriteLine();

                        } while (opcT == 's');

                        // Venda
                        Console.WriteLine($"Total da compra: {precoTotal:c}");
                        if (compVenda.Verba >= precoTotal)
                        {
                            Venda ve = new Venda(vendVenda, compVenda, prodsVenda);
                            compVenda.Verba -= precoTotal;
                            vendVenda.Comissao += precoTotal * 2 / 100;
                            vendas.Add(ve);
                            Console.WriteLine("Venda concluída!");
                            ve.MostrarAtributos();
                        }
                        else
                            Console.WriteLine("Verba insuficiente. Compra cancelada.");
                    }
                }
            }
            else if (opc == 5)
            {
                Console.WriteLine("1 - Vendedores");
                Console.WriteLine("2 - Compradores");
                Console.WriteLine("3 - Vendas");
                Console.Write("Digite a opção desejada: ");
                int opcT = Convert.ToInt32(Console.ReadLine());

                if (opcT == 1)
                    foreach (Vendedor v in vends)
                        v.MostrarAtributos();
                else if (opcT == 2)
                    foreach (Comprador c in comps)
                        c.MostrarAtributos();
                else if (opcT == 3)
                {
                    foreach (Venda ve in vendas)
                        ve.MostrarAtributos();
                }
                else
                    Console.WriteLine("Opção inválida.");
            }

            if (opc > 0 && opc < 6)
            {
                Console.WriteLine();
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        } while (opc > 0 && opc < 6);
    }
}