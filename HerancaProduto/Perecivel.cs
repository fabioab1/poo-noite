using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaProduto
{
    public class Perecivel : Produto
    {
        private string dtValidade;
        private string dtFabricacao;
        private string lote;

        public string DtValidade{
            set{
                this.dtValidade = value;
            }
            get{
                return this.dtValidade;
            }
        }

        public string DtFabricacao{
            set{
                this.dtFabricacao = value;
            }
            get{
                return this.dtFabricacao;
            }
        }

        public string Lote{
            set{
                this.lote = value;
            }
            get{
                return this.lote;
            }
        }

        public Perecivel() : base()
        {
            
        }
        
        public Perecivel(int codigo, string nome, double preco, string validade, string fabricacao, string lote) : base(codigo, nome, preco)
        {
            DtValidade = validade;
            DtFabricacao = fabricacao;
            Lote = lote;
        }

        public void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("Data de validade: " + DtValidade + "\tData de fabricação: " + DtFabricacao + "\tLote: " + Lote);
        }

    }
}