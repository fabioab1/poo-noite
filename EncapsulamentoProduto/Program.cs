// Main

using EncapsulamentoProduto;

Produto p1 = new Produto();
p1.Nome = "Arroz";
p1.Preco = 15.99;
p1.Qntd = 1;

Produto p2 = new Produto();
p2.Nome = "Smartphone";
p2.Preco = 899.90;
p2.Qntd = 4;

System.Console.WriteLine("Produto 1");
System.Console.WriteLine($"Nome: {p1.Nome}\tPreço: {p1.Preco}\tQuantidade: {p1.Qntd}");
System.Console.WriteLine("Produto 2");
System.Console.WriteLine($"Nome: {p2.Nome}\tPreço: {p2.Preco}\tQuantidade: {p2.Qntd}");

Produto p3 = new Produto();
System.Console.Write($"Digite o nome do produto: ");
p3.Nome = Console.ReadLine();
System.Console.Write($"Digite o preço do produto: ");
p3.Preco = Convert.ToDouble(Console.ReadLine());
System.Console.Write($"Digite a quantidade do produto: ");
p3.Qntd = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Produto 3");
System.Console.WriteLine($"Nome: {p3.Nome}\tPreço: {p3.Preco:c}\tQuantidade: {p3.Qntd}");
