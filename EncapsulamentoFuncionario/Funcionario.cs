using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoFuncionario
{
    public class Funcionario
    {
        private int codigo;
        private string nome;
        private double salario;

        // Declaração dos métodos.
        /*
        Declaração dos métodos get e set parecido com

        public void setCodigo(int codigo)
        {
            this.codigo = codigo;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public void setSalario(double salario)
        {
            this.salario = salario;
        }

        public int getCodigo() => this.codigo;
        public string getNome() => this.nome;
        public double getSalario() => this.salario;
        */
        public int Codigo{
            set{
                this.codigo = value;
            }
            get{
                return this.codigo;
            }
        }

        public string Nome{
            set{
                nome = value; // Não preciso usar o "this", já que ele diferencia por causa da maiúscula da função.
            }
            get{
                return this.nome;
            }
        }

        public double Salario{
            get{ // Posso inverter a ordem também, sem problemas.
                return this.salario;
            }
            set{
                salario = value;
            }
        }

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