using EncapsulamentoFuncionario;
/* 
Exemplo de encapsulamento parecido com Java e PHP.

Funcionario f1 = new Funcionario();
f1.setCodigo(1);
System.Console.WriteLine($"Código: {f1.getCodigo()}");

Funcionario abobrinha = new Funcionario();
abobrinha.setCodigo(7);
System.Console.WriteLine($"Código: {abobrinha.getCodigo()}");
*/

Funcionario f1 = new Funcionario();
f1.Codigo = 1; // Aqui é executado o método set (ele sabe que é o set)
f1.Nome = "Fábio";
f1.Salario = 2000;
System.Console.WriteLine($"Código: {f1.Codigo}"); // Aqui ele chama o get (ele sabe que é o get)
System.Console.WriteLine($"Nome: {f1.Nome}");
System.Console.WriteLine($"Salário: {f1.Salario}");