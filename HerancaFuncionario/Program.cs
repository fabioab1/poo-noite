// Método Main()

using HerancaFuncionario;

GerenciadorBonificacao gb = new GerenciadorBonificacao();

Funcionario func1 = new Funcionario(1, "Bob", 1000);
func1.MostrarAtributos();
Console.WriteLine($"Bonificação: {func1.CalcularBonificacao():c}");
gb.TotalizadorBonificacao(func1);

Secretario func2 = new Secretario(2, "Beto", 1000);
func2.MostrarAtributos();
Console.WriteLine($"Bonificação: {func2.CalcularBonificacao():c}");
gb.TotalizadorBonificacao(func2);

Gerente func3 = new Gerente(3, "Bia", 1000);
func3.MostrarAtributos();
Console.WriteLine($"Bonificação: {func3.CalcularBonificacao():c}");
gb.TotalizadorBonificacao(func3);

Diretor func4 = new Diretor(4, "Teo", 1000);
func4.MostrarAtributos();
Console.WriteLine($"Bonificação: {func4.CalcularBonificacao():c}");
gb.TotalizadorBonificacao(func4);

gb.MostrarTotal();