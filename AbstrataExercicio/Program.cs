// Método Main()

using AbstrataExercicio;

Produto p = new Produto();


Disco d = new Disco(1,21, "Emicida","Laboratório Fantasma");
d.AtualizarPreco(100);
Console.WriteLine(d.Preco);

Livro l = new Livro(2, 300, "Livro", 1111111);
l.AtualizaPreco(200);
Console.WriteLine(l.Preco);