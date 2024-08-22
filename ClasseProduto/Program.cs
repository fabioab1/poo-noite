using ClasseProduto;

Produto p1 = new Produto("Halls de Melancia", 4.99);
Produto p2 = new Produto("Café", 12.99);
Produto p3 = new Produto("Smartphone Motorola", 899.90);

p1.MostrarDados();
p1.AdicionarProduto(5);
p1.RemoverProduto(3);
System.Console.WriteLine($"Valor total no estoque: R$ {p1.ValorTotalEstoque()}");

System.Console.WriteLine();

p2.MostrarDados();
p2.AdicionarProduto(10);
p2.RemoverProduto(4);
System.Console.WriteLine($"Valor total no estoque: R$ {p2.ValorTotalEstoque()}");

System.Console.WriteLine();

p3.MostrarDados();
p3.AdicionarProduto(2);
p3.RemoverProduto(1);
System.Console.WriteLine($"Valor total no estoque: R$ {p3.ValorTotalEstoque()}");
