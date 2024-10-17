using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorAluno
{
    public class Aluno
    {
        private string nome;
        private long matricula;
        private static long contador;

        static Aluno()
        {
            contador = 1570482313000; // Construtor é acionado quando o programa é iniciado.
        }

        public Aluno()
        {
            Matricula = contador;
            contador++;
        }

        public Aluno(string nome)
        {
            Nome = nome;
            Matricula = contador;
            contador++;
        }

        public string Nome{
            set{
                this.nome = value;
            }
            get{
                return this.nome;
            }
        }

        public long Matricula{
            set{
                this.matricula = value;
            }
            get{
                return this.matricula;
            }
        }

        public void RelatorioAcademico()
        {
            Console.WriteLine($"RA: {Matricula}");
            Console.WriteLine($"Nome: {Nome}");
        }
    }
}