using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    public class Comissionado : Funcionario
    {
        private double comissao = 0.20;

        public Comissionado(int codigo, string nome, double salario, double comissao) : base(codigo, nome, salario)
        {
            Comissao = comissao;
        }

        public double Comissao{
            set{
                this.comissao = value;
            }
            get{
                return this.comissao;
            }
        }

        public override double CalcularSalario(int diasUteis)
        {
            return (Salario / 30 * diasUteis) * comissao + Salario;
        }

        public override void MostrarAtributos()
        {
            base.MostrarAtributos();
            Console.WriteLine($"Comissão: {Comissao*100}%");
        }
    }
}