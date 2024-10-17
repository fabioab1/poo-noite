using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Venda
    {
        private Comprador comp;
        private Vendedor vend;
        private List<Produto> vetProd;

        public Comprador Comp{
            set{
                this.comp = value;
            }
            get{
                return this.comp;
            }
        }

        public Vendedor Vend{
            set{
                this.vend = value;
            }
            get{
                return this.vend;
            }
        }

        public List<Produto> VetProd{
            set{
                this.vetProd = value;
            }
            get{
                return this.vetProd;
            }
        }

        public Venda(Vendedor vend, Comprador comp, List<Produto> prods)
        {
            Vend = vend;
            Comp = comp;
            VetProd = prods;
        }

        public void MostrarAtributos()
        {
            if (Comp != null)
                Console.WriteLine($"Comprador: {Comp.Nome}");
            if (Vend != null)
                Console.WriteLine($"Vendedor: {Vend.Nome}");
            Console.WriteLine("Produtos:");
            if (VetProd != null)
                foreach (Produto p in VetProd)
                    p.MostrarAtributos();
        }
    }
}