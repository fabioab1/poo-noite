using ConstrutorAluno;

internal class Program
{
    private static void Main(string[] args)
    {
        /* 
        ---------------------------------------------------------------------------------------
        Criar a classe Aluno, com os atributos matricula, nome

        Utilizar o atributo static para criar as matrículas de forma automática a cada
        instância seguindo o padrão Fatec 1570482313000
        O atributo matricula não será static
        Utilize se quiser o atributo contador para auxiliar a contagem e registro da matricula
        (uma variável normal (atributo) pode se comunicar com uma variável static)
        Criar o método mostrar e chamar após cada instância
        Instancie pelo menos 2 objetos de construtores diferentes (2 construtores diferentes:
        a matricula é para ser gerada automaticamente nos 2 construtores, se passar a matricula
        por parâmetro não será gerada automaticamente...)

        Entregar pelo Teams o arquivo Aluno.cs e Program.cs
        Até dia 18/09

        Usar uma variável static para fazer a contagem, o atributo matricula é particular da
        classe
        ---------------------------------------------------------------------------------------
        */

        Aluno a1 = new Aluno();
        a1.RelatorioAcademico();

        System.Console.WriteLine();

        Aluno a2 = new Aluno("Fábio");
        a2.RelatorioAcademico();

        System.Console.WriteLine();

        Aluno a3 = new Aluno("Lucas");
        a3.RelatorioAcademico();

        System.Console.WriteLine();

        Aluno a4 = new Aluno("Teo");
        a4.RelatorioAcademico();

        System.Console.WriteLine(); // Pular linha

        Aluno[] alunos = new Aluno[40];

        for (int i = 0; i < alunos.Length; i++)
        {
            alunos[i] = new Aluno("Aluno"+i);
            alunos[i].RelatorioAcademico();
            System.Console.WriteLine();
        }
    }
}