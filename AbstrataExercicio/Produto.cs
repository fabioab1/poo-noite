using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataExercicio
{
    public abstract class Produto
    {
        private int codigo;
        private double preco;

        public int Codigo{
            set{
                this.codigo = value;
            }
            get{
                return this.codigo;
            }
        }

        public double Preco{
            set{
                this.preco = value;
            }
            get{
                return this.preco;
            }
        }

        public Produto(int codigo, double preco)
        {
            Codigo = codigo;
            Preco = preco;
        }

        public abstract void AtualizaPreco(double preco);
    }
}