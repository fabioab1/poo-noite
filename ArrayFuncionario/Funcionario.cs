using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayFuncionario
{
    public class Funcionario
    {
        public int codigo;
        public string nome;
        public double salario;

        // Declaração dos métodos.
        public void MostraAtributos()
        {
            System.Console.WriteLine($"Código: {codigo}\n" +
            $"Nome: {nome}\n" +
            $"Salário: R$ {salario.ToString("0.00")}.");
        }

        public void AumentarSalario(int porcentagem)
        {
            salario += salario * porcentagem / 100;
        }

        // Criar um método para aplicar uma porcentagem
        // de aumento ao salário.
    }
}