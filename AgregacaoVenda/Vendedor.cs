using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Vendedor
    {
        private double comissao;
        private string nome;

        public double Comissao{
            set{
                this.comissao = value;
            }
            get{
                return this.comissao;
            }
        }

        public string Nome{
            set{
                this.nome = value;
            }
            get{
                return this.nome;
            }
        }

        public Vendedor(string nome)
        {
            Comissao = 0;
            Nome = nome;
        }

        public void MostrarAtributos()
        {
            Console.WriteLine($"Nome: {Nome}\tComissão: {comissao:c}");
        }
    }
}