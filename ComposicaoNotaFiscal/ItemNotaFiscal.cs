using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal
{
    public class ItemNotaFiscal
    {
        private int quantidade;

        public int Quantidade{
            set{
                this.quantidade = value;
            }
            get{
                return this.quantidade;
            }
        }

        public ItemNotaFiscal(int qntde)
        {
            Quantidade = qntde;
        }

        ~ItemNotaFiscal(){ // Destrutor da classe
            Console.WriteLine("Destruir item nota fiscal.");
        }
    }
}