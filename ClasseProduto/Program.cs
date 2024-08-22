using ClasseProduto;

Produto p1 = new Produto("Halls de Melancia", 4.99);
p1.qntd = 5;

Produto p2 = new Produto("Café", 12.99);
p2.qntd = 6;

System.Console.Write("Digite o nome do produto: ");
string nome = Console.ReadLine();
System.Console.Write("Digite o preço do produto: ");
double preco = Convert.ToDouble(Console.ReadLine());
Produto p3 = new Produto(nome, preco);
p3.qntd = 2;

p1.MostrarDados();
p1.AdicionarProduto(5);
p1.RemoverProduto(3);
System.Console.WriteLine($"Valor total no estoque: {p1.ValorTotalEstoque():c}");

System.Console.WriteLine();

p2.MostrarDados();
p2.AdicionarProduto(10);
p2.RemoverProduto(4);
System.Console.WriteLine($"Valor total no estoque: {p2.ValorTotalEstoque():c}");

System.Console.WriteLine();

p3.MostrarDados();
p3.AdicionarProduto(2);
p3.RemoverProduto(1);
System.Console.WriteLine($"Valor total no estoque: {p3.ValorTotalEstoque():c}");
