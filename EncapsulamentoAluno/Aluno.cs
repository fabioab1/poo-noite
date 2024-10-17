using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoAluno
{
    public class Aluno
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public double P1 { get; set; }
        public double P2 { get; set; }
        public double Media { get; private set; } // A média será calculada, não faz sentido ela ter um set público.

        // Declaração dos métodos
        public void CalcularMedia()
        {
            Media = (P1+P2) / 2;
        }
        public void MostrarDados()
        {
            System.Console.WriteLine($"Matrícula: {Matricula}");
            System.Console.WriteLine($"Nome: {Nome}");
            System.Console.WriteLine($"P1 = {P1:n}");
            System.Console.WriteLine($"P2 = {P2:n}");
            System.Console.WriteLine($"Média (({P1:n} + {P2:n}) / 2) = {Media:n}");
        }
    }
}