using ConstrutorProduto;

Produto p1 = new Produto();
p1.MostrarAtributos();

System.Console.WriteLine();

Produto p2 = new Produto("Mouse", 70.99);
p2.MostrarAtributos();

System.Console.WriteLine();

Produto p3 = new Produto("Mouse", 70.99, 5);
p3.MostrarAtributos();

System.Console.WriteLine();

Produto p4 = new Produto(1, "Mouse", 70.99, 5);
p4.MostrarAtributos();