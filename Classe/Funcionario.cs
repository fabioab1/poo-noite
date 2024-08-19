using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classe
{
    public class Funcionario
    {
        // Declaração dos atributos.
        public int codigo;
        public string nome;
        public double salario;

        // Declaração dos métodos.
        public void MostrarInfos()
        {
            System.Console.WriteLine($"Código: {codigo}\nNome: {nome}\nSalário: R$ {salario}");
        }

    }
}