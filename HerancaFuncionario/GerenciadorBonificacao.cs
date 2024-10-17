using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionario
{
    public class GerenciadorBonificacao
    {
        private double totalBonificacao;

        public double TotalBonificacao{
            private set{
                this.totalBonificacao = value;
            }
            get{
                return this.totalBonificacao;
            }
        }

        public void TotalizadorBonificacao(Funcionario funcionario)
        {
            this.TotalBonificacao += funcionario.CalcularBonificacao();
        }

        public void TotalizadorBonificacao(Secretario secretario)
        {
            this.TotalBonificacao += secretario.CalcularBonificacao();
        }

        public void TotalizadorBonificacao(Gerente gerente)
        {
            this.TotalBonificacao += gerente.CalcularBonificacao();
        }

        public void TotalizadorBonificacao(Diretor diretor)
        {
            this.TotalBonificacao += diretor.CalcularBonificacao();
        }

        public void MostrarTotal()
        {
            Console.WriteLine($"O total gasto com a bonificação é de: {TotalBonificacao:c}");
        }
    }
}