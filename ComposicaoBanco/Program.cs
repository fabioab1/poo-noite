// Método Main()

using ComposicaoBanco;
using System.Threading;

/*
Banco bradesco = new Banco();

ContaCorrente c1 = new ContaCorrente();
c1.GerarExtrato();

Poupanca p1 = new Poupanca();
p1.GerarRendimento();

bradesco.Contas.Add(c1);
bradesco.Poups.Add(p1);
*/

Console.Clear();

int i = 0;
while(i <= 100)
{
    Console.Clear();
    Console.WriteLine("Gerenciador de Bancos do Brasil v1.0");
    Console.Write("Carregando: ");
    Console.Write(i + "%");
    Thread.Sleep(500);
    i += 10;
}

Console.WriteLine("\nSeja bem-vindo!");
Thread.Sleep(1000);
Console.Clear();
Console.WriteLine("Administrador: NÃO INFORMADO.");
Thread.Sleep(1000);
Console.Clear();

int opc;
List<Banco> bancos = new List<Banco>();

do
{    
    Console.Clear();
    Console.WriteLine("GBB v1.0");
    Console.WriteLine("1 - Acessar banco");
    Console.WriteLine("2 - Cadastrar novo banco");
    Console.WriteLine("3 - Remover banco");
    Console.WriteLine("4 - Exibir bancos");
    Console.WriteLine("5 - Sair");

    Console.Write("Digite a opção desejada: ");
    opc = Convert.ToInt32(Console.ReadLine());

    bool jaPressionado = false;

    if (opc == 1)
    {
        Console.WriteLine("Bancos cadastrados: ");
        foreach (Banco b in bancos)
            Console.WriteLine(b.Nome);

        Console.Write("Digite o nome do banco que deseja acessar: ");
        string nome = Console.ReadLine();
        Banco bancoAcessar = null;

        foreach (Banco b in bancos)
        {
            if (nome == b.Nome)
            {
                bancoAcessar = b;
                break;
            }
        }

        if (bancoAcessar != null)
        {
            int opc2;

            do
            {
                Console.Clear();
                Console.WriteLine(bancoAcessar.Nome);
                Console.WriteLine("1 - Cadastrar nova conta");
                Console.WriteLine("2 - Remover uma conta");
                Console.WriteLine("3 - Exibir contas cadastradas");
                Console.WriteLine("4 - Realizar depósito");
                Console.WriteLine("5 - Sacar");
                Console.WriteLine("6 - Gerar extrato/rendimento");
                Console.WriteLine("7 - Voltar");

                Console.Write("Digite a opção desejada: ");
                opc2 = Convert.ToInt32(Console.ReadLine());

                if (opc2 == 1)
                {
                    Console.WriteLine("1 - Conta-Corrente");
                    Console.WriteLine("2 - Conta-Poupança");
                    Console.Write("Digite a conta desejada: ");
                    int opc3 = Convert.ToInt32(Console.ReadLine());

                    if (opc3 == 1)
                    {
                        Console.Write("Digite o nome do titular: ");
                        string nomeT = Console.ReadLine();

                        ContaCorrente cc1 = new ContaCorrente(nomeT);
                        bancoAcessar.Contas.Add(cc1);
                        Console.WriteLine("Conta-Corrente criada com sucesso!");
                        cc1.GerarExtrato();
                    }
                    else if (opc3 == 2)
                    {
                        Console.Write("Digite o nome do titular: ");
                        string nomeT = Console.ReadLine();

                        Poupanca pp1 = new Poupanca(nomeT);
                        bancoAcessar.Poups.Add(pp1);
                        Console.WriteLine("Conta-Poupança criada com sucesso!");
                        pp1.GerarRendimento();
                    }
                    else
                        Console.WriteLine("Opção inválida.");
                }
                else if (opc2 == 2)
                {
                    Console.WriteLine("Digite o número da conta que deseja remover: ");
                    int numero = Convert.ToInt32(Console.ReadLine());
                    ContaCorrente contaCorrenteRemover = null;
                    Poupanca poupancaRemover = null;

                    foreach (ContaCorrente cc in bancoAcessar.Contas)
                    {
                        if (numero == cc.Numero)
                        {
                            contaCorrenteRemover = cc;
                            break;
                        }
                    }
                    if (contaCorrenteRemover == null)
                    {
                        foreach (Poupanca pp in bancoAcessar.Poups)
                        {
                            if (numero == pp.Numero)
                            {
                                poupancaRemover = pp;
                                break;
                            }
                        }
                    }

                    if (contaCorrenteRemover != null)
                    {
                        bancoAcessar.Contas.Remove(contaCorrenteRemover);
                        Console.WriteLine("Conta deletada.");
                    }
                    else if (poupancaRemover != null)
                    {
                        bancoAcessar.Poups.Remove(poupancaRemover);
                        Console.WriteLine("Conta deletada.");
                    }
                    else
                        Console.WriteLine("Conta não encontrada.");
                }
                else if (opc2 == 3)
                {
                    Console.WriteLine("Contas cadastradas");

                    Console.WriteLine("Contas-Correntes:");
                    foreach (ContaCorrente cc in bancoAcessar.Contas)
                        Console.WriteLine($"Nº da conta: {cc.Numero}\tTitular: {cc.Titular}.");

                    Console.WriteLine();

                    Console.WriteLine("Contas-Poupança:");
                    foreach (Poupanca pp in bancoAcessar.Poups)
                        Console.WriteLine($"Nº da conta: {pp.Numero}\tTitular: {pp.Titular}");
                }
                else if (opc2 == 4)
                {
                    Console.Write("Digite o número da conta para depositar: ");
                    int numero = Convert.ToInt32(Console.ReadLine());
                    bool contaEncontrada = false;

                    foreach (ContaCorrente cc in bancoAcessar.Contas)
                    {
                        if (cc.Numero == numero)
                        {
                            contaEncontrada = true;
                            Console.Write("Digite o valor para depósito: ");
                            double valor = Convert.ToInt32(Console.ReadLine());
                            cc.Depositar(valor);
                            Console.WriteLine("Depósito realizado!");
                            cc.GerarExtrato();
                            break;
                        }
                    }
                    if (!contaEncontrada)
                    {
                        foreach (Poupanca pp in bancoAcessar.Poups)
                        {
                            if (pp.Numero == numero)
                            {
                                contaEncontrada = true;
                                Console.Write("Digite o valor para depósito: ");
                                double valor = Convert.ToInt32(Console.ReadLine());
                                pp.Depositar(valor);
                                Console.WriteLine("Depósito realizado!");
                                pp.GerarRendimento();
                                break;
                            }
                        }
                    }

                    if (!contaEncontrada)
                        Console.WriteLine("Conta não encontrada.");
                }
                else if (opc2 == 5)
                {
                    Console.Write("Digite o número da conta que deseja sacar: ");
                    int numero = Convert.ToInt32(Console.ReadLine());
                    bool contaEncontrada = false;

                    foreach (ContaCorrente cc in bancoAcessar.Contas)
                    {
                        if (cc.Numero == numero)
                        {
                            contaEncontrada = true;
                            Console.Write("Digite o valor do saque: ");
                            double valor = Convert.ToDouble(Console.ReadLine());
                            cc.Sacar(valor);
                            break;
                        }
                    }
                    if (!contaEncontrada)
                    {
                        foreach (Poupanca pp in bancoAcessar.Poups)
                        {
                            if (pp.Numero == numero)
                            {
                                contaEncontrada = true;
                                Console.Write("Digite o valor do saque: ");
                                double valor = Convert.ToDouble(Console.ReadLine());
                                pp.Sacar(valor);
                                break;
                            }
                        }
                    }

                    if (!contaEncontrada)
                        Console.WriteLine("Conta não encontrada.");
                }
                else if (opc2 == 6)
                {
                    Console.Write("Digite o número da conta para gerar o extrato/rendimento: ");
                    int numero = Convert.ToInt32(Console.ReadLine());
                    bool contaEncontrada = false;

                    foreach (ContaCorrente cc in bancoAcessar.Contas)
                    {
                        if (cc.Numero == numero)
                        {
                            cc.GerarExtrato();
                            contaEncontrada = true;
                            break;
                        }
                    }

                    if (!contaEncontrada)
                    {
                        foreach (Poupanca pp in bancoAcessar.Poups)
                        {
                            if (pp.Numero == numero)
                            {
                                pp.GerarRendimento();
                                contaEncontrada = true;
                                break;
                            }
                        }
                    }

                    if (!contaEncontrada)
                        Console.WriteLine("Conta não encontrada.");
                }
                if (opc2 > 0 && opc2 < 7)
                {
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    jaPressionado = true;
                }
            } while (opc2 > 0 && opc2 < 7);
        }
        else
            Console.WriteLine($"O banco \"{nome}\" não está cadastrado.");
    }
    else if (opc == 2)
    {
        Console.Write("Digite o nome do banco: ");
        string nome = Console.ReadLine();
        bool bancoExistente = false;

        foreach (Banco b in bancos)
            if (nome == b.Nome)
                bancoExistente = true;

        if (!bancoExistente)
        {
            bancos.Add(new Banco(nome));
            Console.WriteLine($"{nome} adicionado com sucesso!");
        }
        else
            Console.WriteLine($"O banco \"{nome}\" já existe.");

    }
    else if (opc == 3)
    {
        Console.Write("Digite o nome do banco para remover: ");
        string nome = Console.ReadLine();
        Banco removerBanco =  null;

        foreach (Banco b in bancos)
        {
            if (b.Nome == nome)
            {
                removerBanco = b;
                break;
            }
        }

        if (removerBanco != null)
        {
            bancos.Remove(removerBanco);
            Console.WriteLine($"{nome} removido.");
        }
        else
            Console.WriteLine($"Nenhum banco \"{nome}\" encontrado.");
    }
    else if (opc == 4)
    {
        Console.WriteLine("Bancos cadastrados: ");
        foreach (Banco b in bancos)
            Console.WriteLine(b.Nome);
    }

    if (!jaPressionado && opc > 0 && opc < 5)
    {
        Console.WriteLine("\nPressione qualquer tecla para continuar...");
        Console.ReadKey();
    }
} while (opc > 0 && opc < 5);