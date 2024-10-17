// Método Main()

using AbstratoFuncionario;

Assalariado a1 = new Assalariado(1, "Teo", 1000);
Assalariado a2 = new Assalariado(2, "Ana", 1500);
Comissionado c1 = new Comissionado(3, "Joe", 1400, 0.20);
Comissionado c2 = new Comissionado(4, "Matteo", 1500, 0.30);

Departamento d1 = new Departamento(1, "Saneamento de Água e Esgoto");
d1.VetF = new List<Funcionario>();
d1.MostrarAtributos();
d1.Admitir(a1);
d1.Admitir(c1);
d1.Listar();
Console.WriteLine($"Total: {d1.CalcularFolha(30)}");
// d1.Demitir(1);
// d1.Listar();

Departamento d2 = new Departamento(2, "Infotech");
d2.VetF = new List<Funcionario>();
d2.MostrarAtributos();
d2.Admitir(a2);
d2.Admitir(c2);
d2.Listar();
Console.WriteLine($"Total: {d2.CalcularFolha(30)}");
