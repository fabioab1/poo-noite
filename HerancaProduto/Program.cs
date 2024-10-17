// Método Main()

using HerancaProduto;

Produto p1 = new Produto();
p1.Codigo = 1;
p1.Nome = "Garfo";
p1.Preco = 4.99;
p1.Mostrar();

Produto p2 = new Produto(2, "Estojo", 15);
p2.Mostrar();

Perecivel pe = new Perecivel(3, "Carne Moída", 38, "18/10/2024", "16/09/2024", "022024");
pe.Mostrar();